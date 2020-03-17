using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SQLite;//подключение к БД

namespace Haberdashery_course
{
    public partial class AddOrEditClient : Form
    {
        public static readonly string connection = "Data Source=DataBase.db";//указываем путь к БД
        SQLiteConnection conn;
        SQLiteCommand command;
        SQLiteDataReader reader;
        string sqlQuery;
        bool whatToDo;
        int clientID;
        public AddOrEditClient(bool whatToDo)
        {
            InitializeComponent();
            this.Text = "Реєстрація клієнта";
            this.whatToDo = whatToDo;
            conn = new SQLiteConnection(connection);
            conn.Open();

        }
        public AddOrEditClient(bool whatToDo, int clientID)
        {
            InitializeComponent();
            this.Text = "Редагування";
            this.whatToDo = whatToDo;
            this.clientID = clientID;
            conn = new SQLiteConnection(connection);
            conn.Open();
            sqlQuery = string.Format("SELECT surname, name, fathername, phoneNumber, mail FROM Client WHERE ID = \"{0}\"", clientID);
            command = new SQLiteCommand(sqlQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                surnameTextBx.Text = reader[0].ToString();
                nameTextBx.Text = reader[1].ToString();
                fathernameTextBx.Text = reader[2].ToString();
                phoneNumberTextBx.Text = reader[3].ToString();
                mailTextBx.Text = reader[4].ToString();
            }
            reader.Close();
        }

        private void confirmAddClientButton_Click(object sender, EventArgs e)
        {
            if (surnameTextBx.Text != "" && nameTextBx.Text != "" && fathernameTextBx.Text != "" && mailTextBx.Text != "" && phoneNumberTextBx.MaskCompleted)
            {
                string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Match isMatch = Regex.Match(mailTextBx.Text, pattern, RegexOptions.IgnoreCase);
                if (!isMatch.Success)
                {
                    MessageBox.Show("Електронна адреса введена не вірно!", "Увага!");
                    return;
                }
                if (whatToDo)
                {
                    sqlQuery = string.Format("INSERT INTO Client (surname, name, fathername, phoneNumber, mail) VALUES(\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\") ",
                        surnameTextBx.Text, nameTextBx.Text, fathernameTextBx.Text, phoneNumberTextBx.Text, mailTextBx.Text);
                    command = new SQLiteCommand(sqlQuery, conn);
                    reader = command.ExecuteReader();
                    MessageBox.Show("Успішне додання!", "Гарні новини!", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    sqlQuery = string.Format("UPDATE Client SET surname = \"{0}\", name = \"{1}\", fathername = \"{2}\", " +
                                " phoneNumber = \"{3}\", mail = \"{4}\" WHERE ID = \"{5}\"",
                                surnameTextBx.Text, nameTextBx.Text, fathernameTextBx.Text, phoneNumberTextBx.Text, mailTextBx.Text, clientID);
                    command = new SQLiteCommand(sqlQuery, conn);
                    command.ExecuteNonQuery();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Увага!");
            }
        }

        private void AddOrEditClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void surnameTextBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nameTextBx.TextLength == 0 && e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
            if (e.KeyChar == (char)Keys.Enter) nameTextBx.Focus();
            if (e.KeyChar == '\'' && surnameTextBx.TextLength == 0) { e.Handled = true; return; }
            if ((e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == 'ї' || e.KeyChar == '\b' || e.KeyChar == 'ґ' || e.KeyChar == 'є'
                || e.KeyChar == 'и' || e.KeyChar == 'і' || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || e.KeyChar == 'Ї' || e.KeyChar == '\b'
                || e.KeyChar == 'Ґ' || e.KeyChar == 'Є' || e.KeyChar == 'І' || e.KeyChar == '\'')
            {
                if (surnameTextBx.TextLength == 0) e.KeyChar = char.ToUpper(e.KeyChar);
                else e.KeyChar = char.ToLower(e.KeyChar);
                return;
            }
            e.Handled = true;
        }

        private void nameTextBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nameTextBx.TextLength == 0 && e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
            if (e.KeyChar == (char)Keys.Enter) fathernameTextBx.Focus();
            if (e.KeyChar == '\'' && nameTextBx.TextLength == 0) { e.Handled = true; return; }
            if ((e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == 'ї' || e.KeyChar == '\b' || e.KeyChar == 'ґ' || e.KeyChar == 'є'
                || e.KeyChar == 'и' || e.KeyChar == 'і' || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || e.KeyChar == 'Ї' || e.KeyChar == '\b'
                || e.KeyChar == 'Ґ' || e.KeyChar == 'Є' || e.KeyChar == 'І' || e.KeyChar == '\'')
            {
                if (nameTextBx.TextLength == 0) e.KeyChar = char.ToUpper(e.KeyChar);
                else e.KeyChar = char.ToLower(e.KeyChar);
                return;
            }
            e.Handled = true;
        }

        private void fathernameTextBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nameTextBx.TextLength == 0 && e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
            if (e.KeyChar == (char)Keys.Enter) phoneNumberTextBx.Focus();
            if (e.KeyChar == '\'' && fathernameTextBx.TextLength == 0) { e.Handled = true; return; }
            if ((e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == 'ї' || e.KeyChar == '\b' || e.KeyChar == 'ґ' || e.KeyChar == 'є'
                || e.KeyChar == 'и' || e.KeyChar == 'і' || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || e.KeyChar == 'Ї' || e.KeyChar == '\b'
                || e.KeyChar == 'Ґ' || e.KeyChar == 'Є' || e.KeyChar == 'І' || e.KeyChar == '\'')
            {
                if (fathernameTextBx.TextLength == 0) e.KeyChar = char.ToUpper(e.KeyChar);
                else e.KeyChar = char.ToLower(e.KeyChar);
                return;
            }
            e.Handled = true;
        }

        private void phoneNumberTextBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) mailTextBx.Focus();
        }
    }
}
