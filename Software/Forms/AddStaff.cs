using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Software.Forms
{
    public partial class AddStaff : Form
    {
        Connection connection;
        public AddStaff()
        {
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameEdit.Text != "" && PatrEdit.Text != "" && SecEdit.Text != "" && NumberEdit.Text != "")
            {
                string sql = "INSERT INTO public.\"Staff\" (\"Name_staff\", \"SecondName\", \"Patronymic\", \"PhoneNumber\") VALUES (@Name_staff, @SecondName, @Patronymic, @PhoneNumber)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
                cmd.Parameters.AddWithValue("Name_staff", NameEdit.Text);
                cmd.Parameters.AddWithValue("SecondName", SecEdit.Text);
                cmd.Parameters.AddWithValue("Patronymic", PatrEdit.Text);
                cmd.Parameters.AddWithValue("PhoneNumber", NumberEdit.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Сотрудник успешно добавлен");
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка добавления сотрудника");
                    Close();
                }
            }
        }

        private void AddStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.CloseCon(connection.Connect);
            StaffForm form = new StaffForm();
            form.Show();
        }

        private void NameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != ((char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
