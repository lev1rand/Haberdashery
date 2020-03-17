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
    public partial class CategoryOrMaterial : Form
    {
        public static readonly string connection = "Data Source=DataBase.db";//указываем путь к БД
        SQLiteConnection conn;
        SQLiteCommand command;
        SQLiteDataReader reader;
        string sqlQuery;
        int ID;
        bool whatIsIt;
        public CategoryOrMaterial(bool whatIsIt)
        {
            InitializeComponent();
            conn = new SQLiteConnection(connection);
            conn.Open();
            this.whatIsIt = whatIsIt;
            if (whatIsIt)
            {
                this.Text = "Матеріали";
                cormGrid.Width = 107;
                cormGrid.Location = new Point(69, 30);
                this.Width = 303;
                this.Height = 385;
            }
            else
            {
                this.Text = "Категорії";
                cormGrid.Width = 200;

            }
            UpdateCategoryOrMaterial();
        }

        private void addCorM_Click(object sender, EventArgs e)
        {
            if (newNameTextBox.Text != "")
            {
                if (whatIsIt)
                {
                    sqlQuery = string.Format("INSERT INTO Material (name) VALUES (\"{0}\")", newNameTextBox.Text);
                    command = new SQLiteCommand(sqlQuery, conn);
                    command.ExecuteNonQuery();
                }
                else
                {
                    sqlQuery = string.Format("INSERT INTO Category (name) VALUES (\"{0}\")", newNameTextBox.Text);
                    command = new SQLiteCommand(sqlQuery, conn);
                    command.ExecuteNonQuery();
                }
                UpdateCategoryOrMaterial();
                newNameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть поле інформацією!");
            }
        }

        private void cormGrid_SelectionChanged(object sender, EventArgs e)
        {
            ID = int.Parse(cormGrid[0, cormGrid.CurrentCell.RowIndex].Value.ToString());
        }

        private void deleteCorM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити поле?", "Увага!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (whatIsIt)
                {

                    sqlQuery = string.Format("DELETE FROM Material WHERE ID = \"{0}\"", ID);
                    command = new SQLiteCommand(sqlQuery, conn);
                    reader = command.ExecuteReader();
                }
                else
                {
                    sqlQuery = string.Format("DELETE FROM Category WHERE ID = \"{0}\"", ID);
                    command = new SQLiteCommand(sqlQuery, conn);
                    reader = command.ExecuteReader();
                }
                UpdateCategoryOrMaterial();

            }
            else
            {
                MessageBox.Show("Видалення не було успішним!");
            }

        }

        private void CategoryOrMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
        private void UpdateCategoryOrMaterial()
        {
            cormGrid.Rows.Clear();
            if (whatIsIt)
            {
                sqlQuery = "SELECT ID, name FROM Material";
                command = new SQLiteCommand(sqlQuery, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cormGrid.Rows.Add(reader[0].ToString(), reader[1].ToString());
                }
                reader.Close();
            }
            else
            {
                sqlQuery = "SELECT ID, name FROM Category";
                command = new SQLiteCommand(sqlQuery, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cormGrid.Rows.Add(reader[0].ToString(), reader[1].ToString());
                }
                reader.Close();
            }
        }

    }
}
