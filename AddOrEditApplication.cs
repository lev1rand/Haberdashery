using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;//подключение библиотеки с БД

namespace Haberdashery_course
{
    public partial class AddOrEditApplication : Form
    {
        public static readonly string connection = "Data Source=DataBase.db";//указываем путь к БД
        SQLiteConnection conn;
        SQLiteCommand command;
        SQLiteDataReader reader;
        string sqlQuery;
        int serviceID;
        int rowID;//ID изменяемой заявки
        int clientID;//ID  заказчика
        int productID;//ID изделия
        bool whatToDo;//определение производимой операции(добавить || редактировать?)
        //перегрузка конструкторов
        //один параметр (операция добавления) - тип операции
        public AddOrEditApplication(bool whatToDo)
        {
            InitializeComponent();
            this.Text = "Нова заявка";
            conn = new SQLiteConnection(connection);
            conn.Open();
            this.whatToDo = whatToDo;
            sqlQuery = "SELECT surname, phoneNumber FROM Client";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                chooseClientComBx.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
            }
            reader.Close();

            sqlQuery = "SELECT Products.name, Material.name FROM Products, Material WHERE materialID = Material.ID";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                chooseProductComBx.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
            }
            reader.Close();

            sqlQuery = "SELECT service FROM PriceList";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                choosetypeComBx.Items.Add(reader[0].ToString());
            }
            reader.Close();
            chooseClientComBx.SelectedIndex = 0;
            chooseProductComBx.SelectedIndex = 1;
            choosetypeComBx.SelectedIndex = 1;
        }
        //два параметра(редактирование) - тип операции, ID редактируемой заявки
        public AddOrEditApplication(bool whatToDo, int rowID)
        {
            InitializeComponent();
            this.Text = "Редагування заявки";
            conn = new SQLiteConnection(connection);
            conn.Open();

            this.whatToDo = whatToDo;
            this.rowID = rowID;
            sqlQuery = "SELECT surname, phoneNumber FROM Client";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                chooseClientComBx.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
            }
            reader.Close();

            sqlQuery = "SELECT Products.name, Material.name FROM Products, Material WHERE materialID = Material.ID";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                chooseProductComBx.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
            }
            reader.Close();

            sqlQuery = "SELECT service FROM PriceList";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                choosetypeComBx.Items.Add(reader[0].ToString());
            }
            reader.Close();
            sqlQuery = string.Format("SELECT Client.surname, Client.phoneNumber, Products.name, Material.name" +
                ", description, PriceList.service, cost FROM Application, Client, Products, Material, PriceList" +
                " WHERE Application.ID = \"{0}\" AND clientID = Client.ID AND Products.ID = productID " +
                "AND materialID = Material.ID AND serviceID = PriceList.ID", rowID);
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            string client = "", product = "", service = "";
            while (reader.Read())
            {
                client = reader[0].ToString() + " " + reader[1].ToString();
                product = reader[2].ToString() + " " + reader[3].ToString();
                service = reader[5].ToString();
                descriptionRichTextBx.Text = reader[4].ToString();
                costTextBx.Text = reader[6].ToString();
            }
            reader.Close();
            for (int i = 0; i < chooseClientComBx.Items.Count; i++)
            {
                if (chooseClientComBx.Items[i].ToString() == client)
                {
                    chooseClientComBx.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < chooseProductComBx.Items.Count; i++)
            {
                if (chooseProductComBx.Items[i].ToString() == product)
                {
                    chooseProductComBx.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < choosetypeComBx.Items.Count; i++)
            {
                if (choosetypeComBx.Items[i].ToString() == service)
                {
                    choosetypeComBx.SelectedIndex = i;
                    break;
                }
            }
            costTrackBar.Value = int.Parse(costTextBx.Text);
        }
        //появление ToolTip в случае нехватки места для текста
        private void choosetypeComBx_MouseEnter(object sender, EventArgs e)
        {
            if (choosetypeComBx.SelectedIndex >= 0)
                toolTipService.SetToolTip(choosetypeComBx, choosetypeComBx.Items[choosetypeComBx.SelectedIndex].ToString());
        }
        //изменение текста в поле Стоимость услуги
        private void costTrackBar_Scroll(object sender, EventArgs e)
        {
            costTextBx.Text = costTrackBar.Value.ToString();
        }
        //проверка корректности ввода Стоимости услуги
        private void costTextBx_TextChanged(object sender, EventArgs e)
        {
            if (costTextBx.Text != "")
            {
                if (int.Parse(costTextBx.Text) <= costTrackBar.Maximum && int.Parse(costTextBx.Text) >= costTrackBar.Minimum)
                    costTrackBar.Value = int.Parse(costTextBx.Text);
            }
        }
        //выставление ценового диапазона в TrackBar зависимо от типа выбранной Услуги
        private void choosetypeComBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int min = 0, max = 0;
            sqlQuery = "SELECT service, ID, minCost, maxCost FROM PriceList";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (choosetypeComBx.Text == reader[0].ToString())
                {
                    serviceID = int.Parse(reader[1].ToString());
                    min = int.Parse(reader[2].ToString());
                    max = int.Parse(reader[3].ToString());
                    break;
                }
            }
            reader.Close();
            costTrackBar.Minimum = min;
            costTrackBar.Maximum = max;
        }
        //подтвердить добавление/редактирование
        private void confirmAddAplButton_Click(object sender, EventArgs e)
        {
            if (chooseClientComBx.SelectedIndex > -1 && chooseProductComBx.SelectedIndex > -1 && choosetypeComBx.SelectedIndex > -1 && descriptionRichTextBx.Text != "" &&
                costTrackBar.Value >= costTrackBar.Minimum && costTrackBar.Value <= costTrackBar.Maximum && costTextBx.Text != "")
            {
                if (int.Parse(costTextBx.Text) >= costTrackBar.Minimum && int.Parse(costTextBx.Text) <= costTrackBar.Maximum)
                {
                    if (!whatToDo)//если происходит операция редактирования(обновления)
                    {
                        sqlQuery = string.Format("UPDATE Application SET clientID = \"{0}\", productID = \"{1}\", description = \"{2}\", " +
                            " stateID = \"{3}\", cost = \"{4}\", serviceID = \"{5}\" WHERE ID = \"{6}\"",
                            clientID, productID, descriptionRichTextBx.Text, 1, costTrackBar.Value, serviceID, rowID);
                        command = new SQLiteCommand(sqlQuery, conn);
                        command.ExecuteNonQuery();
                        this.Close();
                    }
                    else//если происходит операция добавления
                    {
                        sqlQuery = string.Format("INSERT INTO Application (clientID, productID, description, createDate, checkoutDate, " +
                            "stateID, cost, serviceID) VALUES (\"{0}\", \"{1}\", \"{2}\", \"{3}\",\"{4}\", \"{5}\", \"{6}\", \"{7}\")", clientID, productID, descriptionRichTextBx.Text,
                            DateTime.Now.ToString(), null, 1, costTrackBar.Value, serviceID);
                        command = new SQLiteCommand(sqlQuery, conn);
                        command.ExecuteNonQuery();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Заповніть, будь ласка, вартість послуги!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Некоректно заповнені поля! Перевірте, будь ласка, ще раз!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //динамическое определение ID выбранного Заказчика
        private void chooseClientComBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] clientInfo = (chooseClientComBx.Text).Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
            sqlQuery = "SELECT ID,phoneNumber FROM Client";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            string phoneNumberDB;
            while (reader.Read())
            {
                phoneNumberDB = reader[1].ToString();
                phoneNumberDB = phoneNumberDB.Remove(0, 1);
                if (clientInfo[1] == phoneNumberDB)
                {
                    clientID = int.Parse(reader[0].ToString());
                    break;
                }
            }
            reader.Close();
        }
        //динамическое определение ID выбранного Изделия
        private void chooseProductComBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] productInfo = (chooseProductComBx.Text).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            sqlQuery = "SELECT Products.ID,Products.name, Material.name FROM Products, Material WHERE materialID = Material.ID";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (productInfo[0] == reader[1].ToString() && productInfo[1] == reader[2].ToString())
                {
                    productID = int.Parse(reader[0].ToString());
                    break;
                }
            }
            reader.Close();
        }
        //в случае, если не получится скроллить TrackBar (минимум и максимум одинаков)
        private void costTrackBar_Enter(object sender, EventArgs e)
        {
            costTextBx.Text = costTrackBar.Value.ToString();
        }
        private void AddOrEditApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void costTextBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void descriptionRichTextBx_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (descriptionRichTextBx.TextLength == 0 && e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }
    }
}
