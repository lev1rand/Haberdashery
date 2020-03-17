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
    public partial class AddOrEditService : Form
    {
        bool whatToDo;
        int serviceID;
        public static readonly string connection = "Data Source=DataBase.db";//указываем путь к БД
        SQLiteConnection conn;
        SQLiteCommand command;
        SQLiteDataReader reader;
        string sqlQuery;
        public AddOrEditService(bool whatToDo)
        {
            InitializeComponent();
            this.Text = "Додавання нової послуги";
            conn = new SQLiteConnection(connection);
            conn.Open();
            this.whatToDo = whatToDo;
        }
        public AddOrEditService(bool whatToDo, int serviceID)
        {
            InitializeComponent();
            this.Text = "Редагування вартості послуги";
            conn = new SQLiteConnection(connection);
            conn.Open();
            this.whatToDo = whatToDo;
            this.serviceID = serviceID;
            sqlQuery = string.Format("SELECT service, minCost, maxCost FROM PriceList WHERE ID = \"{0}\"", serviceID);
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                servicetextBox.Text = reader[0].ToString();
                minCosttextBox.Text = reader[1].ToString(); ;
                maxCosttextBox.Text = reader[2].ToString();
            }
            reader.Close();
            servicetextBox.Enabled = false;
        }

        private void AddOrEditService_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (servicetextBox.Text != "" && minCosttextBox.Text != "" && maxCosttextBox.Text != "")
            {
                if (int.Parse(maxCosttextBox.Text) >= int.Parse(minCosttextBox.Text))
                {
                    if (whatToDo)
                    {
                        sqlQuery = string.Format("INSERT INTO PriceList (service, minCost, maxCost) " +
           " VALUES (\"{0}\", \"{1}\", \"{2}\")", servicetextBox.Text, int.Parse(minCosttextBox.Text), int.Parse(maxCosttextBox.Text));
                        command = new SQLiteCommand(sqlQuery, conn);
                        command.ExecuteNonQuery();
                        this.Close();
                    }
                    else
                    {
                        sqlQuery = string.Format("UPDATE PriceList SET minCost = \"{0}\", maxCost = \"{1}\" WHERE ID = \"{2}\"",
                      int.Parse(minCosttextBox.Text), int.Parse(maxCosttextBox.Text), serviceID);
                        command = new SQLiteCommand(sqlQuery, conn);
                        command.ExecuteNonQuery();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Мінімальна вартість не може бути менша за максимальну!", "Увага, логічна помилка!");
            }
            else
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Увага!");
        }

        private void minCosttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void maxCosttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void servicetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space && servicetextBox.TextLength == 0)
                e.KeyChar = '\0';
        }
    }
}
