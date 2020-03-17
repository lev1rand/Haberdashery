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
    public partial class Authorization : Form
    {
        public static readonly string connection = "Data Source=DataBase.db";//указываем путь к БД
        SQLiteConnection conn;
        SQLiteCommand command;
        SQLiteDataReader reader;
        string sqlQuery;
        public bool whichUser;

        public Authorization()
        {
            conn = new SQLiteConnection(connection);
            conn.Open();
            InitializeComponent();
            sqlQuery = "SELECT userName FROM Users";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                userComboBox.Items.Add(reader[0]);
            }
            reader.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void showPasswordCheckBx_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBx.Checked)
                passwordTextBx.UseSystemPasswordChar = false;
            else
                passwordTextBx.UseSystemPasswordChar = true;
        }
        private void cofirmButton_Click(object sender, EventArgs e)
        {
            string[] userName = new string[2];
            string[] password = new string[2];
            sqlQuery = "SELECT userName, userPassword FROM Users";
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                userName[i] = reader[0].ToString();
                password[i] = reader[1].ToString();
                i++;
            }
            reader.Close();
            if (userComboBox.Text == userName[0] && passwordTextBx.Text == password[0])//если входит админ
            {
                whichUser = true;
                WorkingPanel ap = new WorkingPanel(whichUser);
                ap.Show();
                this.Hide();
                ap.FormClosed += (ap1, e1) =>
                {
                    passwordTextBx.Text = "";
                    this.Show();
                };

            }
            else
            if (userComboBox.Text == userName[1] && passwordTextBx.Text == password[1])//если входит мастер
            {
                whichUser = false;
                WorkingPanel mp = new WorkingPanel(whichUser);
                mp.Show();
                this.Hide();
                mp.FormClosed += (ap1, e1) =>
                {
                    passwordTextBx.Text = "";
                    this.Show();

                };

            }
            else
            {
                MessageBox.Show("Дані не збігаються! Перевірте ще раз!", "Помилка!");
                passwordTextBx.Text = "";
            }
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }

}
