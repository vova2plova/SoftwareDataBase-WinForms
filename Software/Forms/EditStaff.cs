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
    public partial class EditStaff : Form
    {
        Connection connection;
        int id_staff;
        public EditStaff(int id)
        {
            id_staff = id;
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SecEdit.Text != "" && NameEdit.Text != "" && PatrEdit.Text != "" && NumberEdit.Text != "")
            {
                string sql = "UPDATE public.\"Staff\" SET \"Name_staff\" = @Name_staff , \"SecondName\" = @SecondName, \"Patronymic\" = @Patronymic, \"PhoneNumber\" = @PhoneNumber" +
                                " Where \"id_staff\" = '" + id_staff + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
                cmd.Parameters.AddWithValue("Name_staff", NameEdit.Text);
                cmd.Parameters.AddWithValue("SecondName", SecEdit.Text);
                cmd.Parameters.AddWithValue("Patronymic", PatrEdit.Text);
                cmd.Parameters.AddWithValue("PhoneNumber", NumberEdit.Text);
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Информация о сотруднике обновлена");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка обновления");
                        Close();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM public.\"Staff\" Where \"id_staff\" = '" + id_staff+ "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NameEdit.Text = reader[2].ToString();
                SecEdit.Text = reader[1].ToString();
                PatrEdit.Text = reader[3].ToString();
                NumberEdit.Text = reader[4].ToString();
            }
            reader.Close();
        }

        private void EditStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.CloseCon(connection.Connect);
            StaffForm form = new StaffForm();
            form.Show();
        }

        private void SecEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != ((char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
