using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;//подключаем библиотеку SQLite

namespace Haberdashery_course
{
    public partial class WorkingPanel : Form
    {
        public static readonly string connection = "Data Source=DataBase.db";//указываем путь к БД
        SQLiteConnection conn;
        SQLiteCommand command;
        SQLiteDataReader reader;
        string sqlQuery;
        bool whatToDo;//определяет, используется ли форма для добавления или редактирования
        int applicationID, productID, clientID, priceID;
        bool whichUser;//кто зашёл
        public WorkingPanel(bool whichUser)
        {
            conn = new SQLiteConnection(connection);
            conn.Open();
            InitializeComponent();
            //в случае, если заходит мастер, остаются только необходимые вкладки;все остальные удаляются
            if (!whichUser)
            {
                for (int i = 0; i < 3; i++)
                {
                    Menu.TabPages.RemoveAt(1);
                    applicationsOperationsMenuStrip.Items.RemoveAt(0);
                }
                this.Text = "Панель майстра";
            }
            this.whichUser = whichUser;

        }
        private void WorkingPanel_Load(object sender, EventArgs e)
        {
            clientsGrid.MultiSelect = false;
            productsGrid.MultiSelect = false;
            priceListGrid.MultiSelect = false;
            UpdateApplications();
            UpdateClients();
            UpdateProducts();
            UpdatePriceList();
        }
        //добавить заявку
        private void addApplication_Click(object sender, EventArgs e)
        {
            whatToDo = true;
            AddOrEditApplication add = new AddOrEditApplication(whatToDo);
            add.ShowDialog();
            UpdateApplications();
        }
        //редактировать заявку
        private void editApplication_Click(object sender, EventArgs e)
        {
            whatToDo = false;
            AddOrEditApplication edit = new AddOrEditApplication(whatToDo, applicationID);
            edit.ShowDialog();
            UpdateApplications();
        }
        //удалить заявку
        private void deleteApplication_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити замовлення?", "Увага!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sqlQuery = string.Format("DELETE FROM Application WHERE ID = \"{0}\"", applicationID);
                command = new SQLiteCommand(sqlQuery, conn);
                reader = command.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Видалення не було успішним!");
            }
            UpdateApplications();
        }
        //фиксация выбранной в табличке строки
        private void applicationsGrid_SelectionChanged(object sender, EventArgs e)
        {
            applicationID = int.Parse(applicationsGrid[0, applicationsGrid.CurrentCell.RowIndex].Value.ToString());
        }
        //адаптация размеров формы
        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Menu.SelectedIndex)
            {
                case 0:
                    this.Width = 1043;
                    this.Height = 471;
                    break;
                case 1:
                    this.Width = 749;
                    this.Height = 303;
                    break;
                case 2:
                    this.Width = 746;
                    this.Height = 355;
                    break;
                case 3:
                    this.Width = 696;
                    this.Height = 336;
                    break;
            }

        }
        //обновление информации в табличке Заявки
        private void UpdateApplications()
        {
            applicationsGrid.Rows.Clear();
            sqlQuery = "SELECT Application.ID, Client.surname, Products.name, Category.name, Application.description, PriceList.service, Application.cost, State.name, Application.createDate, Application.checkoutDate FROM Application, Client, Products, PriceList, State,Category"
                       + " WHERE clientID = Client.ID AND productID = Products.ID AND stateID = State.ID AND serviceID = PriceList.ID AND categoryID = Category.ID";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                applicationsGrid.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString()
                    , reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
            }
            reader.Close();
        }
        //обновление информации в табличке Заказчики
        private void UpdateClients()
        {
            clientsGrid.Rows.Clear();
            sqlQuery = "SELECT ID, surname, name, fathername, mail, phoneNumber FROM Client";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                clientsGrid.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            }
            reader.Close();
        }
        //обновление информации в табличке Изделия
        private void UpdateProducts()
        {
            productsGrid.Rows.Clear();
            sqlQuery = "SELECT Products.ID, Products.name, Category.name, Material.name FROM Products, Category, Material WHERE categoryID = Category.ID AND materialID = material.ID";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                productsGrid.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
            }
            reader.Close();
        }
        //обновление информации в табличке Прейскурант
        private void UpdatePriceList()
        {
            priceListGrid.Rows.Clear();
            sqlQuery = "SELECT ID, service, minCost, maxCost FROM PriceList";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                priceListGrid.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
            }
            reader.Close();
        }
        private void WorkingPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
        private void WorkingPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
        //добавление нового заказчика
        private void addNewClient_Click(object sender, EventArgs e)
        {
            whatToDo = true;
            AddOrEditClient ac = new AddOrEditClient(whatToDo);
            ac.ShowDialog();
            UpdateClients();
        }
        private void clientsGrid_SelectionChanged(object sender, EventArgs e)
        {
            clientID = int.Parse(clientsGrid[0, clientsGrid.CurrentCell.RowIndex].Value.ToString());
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            whatToDo = false;
            AddOrEditClient ac = new AddOrEditClient(whatToDo, clientID);
            ac.ShowDialog();
            UpdateClients();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити інформацію про замовника?", "Увага!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sqlQuery = string.Format("DELETE FROM Client WHERE ID = \"{0}\"", clientID);
                command = new SQLiteCommand(sqlQuery, conn);
                reader = command.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Видалення не було успішним!");
            }
            UpdateClients();
        }

        private void addNewProduct_Click(object sender, EventArgs e)
        {
            whatToDo = true;
            AddOrEditProduct ap = new AddOrEditProduct(whatToDo);
            ap.ShowDialog();
            UpdateProducts();
        }

        private void editNewProduct_Click(object sender, EventArgs e)
        {
            whatToDo = false;
            AddOrEditProduct ap = new AddOrEditProduct(whatToDo, productID);
            ap.ShowDialog();
            UpdateProducts();
        }

        private void deleteNewProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити інформацію про виріб?", "Увага!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sqlQuery = string.Format("DELETE FROM Products WHERE ID = \"{0}\"", productID);
                command = new SQLiteCommand(sqlQuery, conn);
                reader = command.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Видалення не було успішним!");
            }
            UpdateProducts();
        }

        private void extraProductsInformation_Click(object sender, EventArgs e)
        {

        }

        private void productsGrid_SelectionChanged(object sender, EventArgs e)
        {
            productID = int.Parse(productsGrid[0, productsGrid.CurrentCell.RowIndex].Value.ToString());
        }

        private void addService_Click(object sender, EventArgs e)
        {
            whatToDo = true;
            AddOrEditService aser = new AddOrEditService(whatToDo);
            aser.ShowDialog();
            UpdatePriceList();
        }

        private void delService_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете прибрати послугу?", "Увага!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sqlQuery = string.Format("DELETE FROM PriceList WHERE ID = \"{0}\"", priceID);
                command = new SQLiteCommand(sqlQuery, conn);
                reader = command.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Видалення не було успішним!");
            }
            UpdatePriceList();
        }

        private void changeServiceCost_Click(object sender, EventArgs e)
        {
            whatToDo = false;
            AddOrEditService es = new AddOrEditService(whatToDo, priceID);
            es.ShowDialog();
            UpdatePriceList();
        }

        private void priceListGrid_SelectionChanged(object sender, EventArgs e)
        {
            priceID = int.Parse(priceListGrid[0, priceListGrid.CurrentCell.RowIndex].Value.ToString());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            applicationsGrid.Rows.Clear();
            if (searchSurnameTextBox.Text != "" || searchIDTextBox.Text != "")
            {
                if (searchSurnameTextBox.Text != "" && searchIDTextBox.Text != "")
                {
                    sqlQuery = string.Format("SELECT Application.ID, Client.surname, Products.name, Category.name, Application.description, PriceList.service, Application.cost, State.name, Application.createDate, Application.checkoutDate  " +
                   "FROM Application, Client, Products, PriceList, State, Category  WHERE clientID = Client.ID AND productID = Products.ID AND stateID = State.ID AND serviceID = PriceList.ID " +
                   "AND categoryID = Category.ID AND surname LIKE \"%{0}%\" AND Application.ID LIKE \"%{1}%\"", searchSurnameTextBox.Text, int.Parse(searchIDTextBox.Text));
                }
                else
                {
                    if (searchSurnameTextBox.Text != "")
                    {
                        sqlQuery = string.Format("SELECT Application.ID, Client.surname, Products.name, Category.name, Application.description, PriceList.service, Application.cost, State.name, Application.createDate, Application.checkoutDate  " +
                            "FROM Application, Client, Products, PriceList, State, Category  WHERE clientID = Client.ID AND productID = Products.ID AND stateID = State.ID AND serviceID = PriceList.ID " +
                            "AND categoryID = Category.ID AND surname LIKE \"%{0}%\"", searchSurnameTextBox.Text);
                    }
                    else
                    {
                        sqlQuery = string.Format("SELECT Application.ID, Client.surname, Products.name, Category.name, Application.description, PriceList.service, Application.cost, State.name, Application.createDate, Application.checkoutDate  " +
                "FROM Application, Client, Products, PriceList, State, Category  WHERE clientID = Client.ID AND productID = Products.ID AND stateID = State.ID AND serviceID = PriceList.ID " +
                "AND categoryID = Category.ID AND Application.ID LIKE \"%{0}%\"", int.Parse(searchIDTextBox.Text));
                    }
                }
                command = new SQLiteCommand(sqlQuery, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    applicationsGrid.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString()
                   , reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                }
                reader.Close();
            }

        }

        private void category_Click(object sender, EventArgs e)
        {
            whatToDo = false;
            CategoryOrMaterial c = new CategoryOrMaterial(whatToDo);
            c.ShowDialog();

        }

        private void material_Click(object sender, EventArgs e)
        {
            whatToDo = true;
            CategoryOrMaterial m = new CategoryOrMaterial(whatToDo);
            m.ShowDialog();
        }

        private void canselSearchButton_Click(object sender, EventArgs e)
        {
            searchIDTextBox.Text = "";
            searchSurnameTextBox.Text = "";
            UpdateApplications();
        }

        private void searchSurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = true;
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void searchIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void applicationsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                applicationsGrid.CurrentCell = applicationsGrid[e.ColumnIndex, e.RowIndex];
                applicationsGrid.CurrentRow.Selected = true;
            }

        }

        private void закритиЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (whichUser)
            {
                if (applicationsGrid[7, applicationsGrid.CurrentCell.RowIndex].Value.ToString() == "Відкрита")
                {
                    int stateID = 1;
                    sqlQuery = "SELECT ID FROM State WHERE State.name = \"Закрита\"";
                    command = new SQLiteCommand(sqlQuery, conn);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        stateID = int.Parse(reader[0].ToString());
                    }
                    reader.Close();
                    sqlQuery = "UPDATE Application SET stateID = " + stateID + ", checkOutDate = \"" + DateTime.Now.ToString() + "\" WHERE  Application.ID = " +
                        int.Parse(applicationsGrid[0, applicationsGrid.CurrentCell.RowIndex].Value.ToString()) + ";";
                    command = new SQLiteCommand(sqlQuery, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Заявка була успішно закрита!", "Увага!");
                    UpdateApplications();
                }
                else
                {
                    MessageBox.Show("Заявка вже закрита!");
                }

            }
            else
                MessageBox.Show("На жаль, у вас немає повноажень адміністратора!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
