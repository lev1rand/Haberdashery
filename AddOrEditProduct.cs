using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;//подключение к БД

namespace Haberdashery_course
{
    public partial class AddOrEditProduct : Form
    {
        bool whatToDo;
        int productID;
        int categoryID, materialID;
        public static readonly string connection = "Data Source=DataBase.db";//указываем путь к БД
        SQLiteConnection conn;
        SQLiteCommand command;
        SQLiteDataReader reader;
        string sqlQuery;
        public AddOrEditProduct(bool whatToDo)
        {
            InitializeComponent();
            this.Text = "Реєстрація виробу";
            conn = new SQLiteConnection(connection);
            conn.Open();
            this.whatToDo = whatToDo;
            sqlQuery = "SELECT Category.name FROM Category";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                categoryComboBx.Items.Add(reader[0].ToString());
            }
            reader.Close();
            sqlQuery = "SELECT Material.name FROM Material";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                materialComboBx.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        public AddOrEditProduct(bool whatToDo, int productID)
        {
            InitializeComponent();
            this.Text = "Редагування";
            string category = "", material = "";
            this.whatToDo = whatToDo;
            this.productID = productID;
            conn = new SQLiteConnection(connection);
            conn.Open();
            sqlQuery = "SELECT Category.name FROM Category";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                categoryComboBx.Items.Add(reader[0].ToString());
            }
            reader.Close();
            sqlQuery = "SELECT Material.name FROM Material";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                materialComboBx.Items.Add(reader[0].ToString());
            }
            reader.Close();
            sqlQuery = string.Format("SELECT Products.name, Category.name, Material.name FROM Products, Category, Material WHERE categoryID = Category.ID AND materialID = Material.ID AND Products.ID =  \"{0}\"", productID);
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                productNameTextBx.Text = reader[0].ToString();
                category = reader[1].ToString();
                material = reader[2].ToString();
            }
            reader.Close();
            for (int i = 0; i < categoryComboBx.Items.Count; i++)
            {
                if (categoryComboBx.Items[i].ToString() == category)
                {
                    categoryComboBx.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < materialComboBx.Items.Count; i++)
            {
                if (materialComboBx.Items[i].ToString() == material)
                {
                    materialComboBx.SelectedIndex = i;
                    break;
                }
            }

        }

        private void AddOrEditProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void confirmProductInformationButton_Click(object sender, EventArgs e)
        {
            if (productNameTextBx.Text != "" && categoryComboBx.SelectedIndex > -1 && materialComboBx.SelectedIndex > -1)
            {
                if (whatToDo)
                {
                    sqlQuery = string.Format("INSERT INTO Products (name, categoryID, materialID) " +
        " VALUES (\"{0}\", \"{1}\", \"{2}\")", productNameTextBx.Text, categoryID, materialID);
                    command = new SQLiteCommand(sqlQuery, conn);
                    command.ExecuteNonQuery();
                }
                else
                {
                    sqlQuery = string.Format("UPDATE Products SET name = \"{0}\", categoryID = \"{1}\", materialID = \"{2}\" WHERE ID = \"{3}\"",
                    productNameTextBx.Text, categoryID, materialID, productID);
                    command = new SQLiteCommand(sqlQuery, conn);
                    command.ExecuteNonQuery();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Увага!");
            }
        }

        private void categoryComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlQuery = "SELECT ID, name FROM Category";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (categoryComboBx.Text == reader[1].ToString())
                {
                    categoryID = int.Parse(reader[0].ToString());
                    break;
                }
            }
            reader.Close();
        }

        private void productNameTextBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (productNameTextBx.TextLength == 0 && e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void materialComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlQuery = "SELECT ID, name FROM Material";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (materialComboBx.Text == reader[1].ToString())
                {
                    materialID = int.Parse(reader[0].ToString());
                    break;
                }
            }
            reader.Close();
        }
    }
}
