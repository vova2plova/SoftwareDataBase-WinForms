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
    public partial class EditSoft : Form
    {
        private Connection connection;
        private int id_soft;
        public EditSoft(int id)
        {
            id_soft = id;
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void AddSoft_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM public.\"Soft\" WHERE \"id_soft\" = '" + id_soft + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            NpgsqlDataReader reader= cmd.ExecuteReader();
            while (reader.Read())
            {
                    NameEdit.Text = reader[3].ToString();
                    CategoryBox.Text = reader[1].ToString();
                    PriceEdit.Text = reader[2].ToString();
            }
            reader.Close();
            CategoryBox.Items.Add("Графический редактор");
            CategoryBox.Items.Add("Редактор кода");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameEdit.Text != "" && CategoryBox.Text != "" && PriceEdit.Text != "")
            {
                string sql = "UPDATE public.\"Soft\" SET \"Name\" = @Name, \"category_soft\" = @category_soft, \"Price\" = @Price Where \"id_soft\" = '" + id_soft + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
                cmd.Parameters.AddWithValue("Name", NameEdit.Text);
                cmd.Parameters.AddWithValue("category_soft", CategoryBox.Text.ToString());
                cmd.Parameters.AddWithValue("Price", Convert.ToInt32(PriceEdit.Text));
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Программное обеспечение успешно добавлено");
                    Close();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка, попробуйте позже");
                }
            }
        }

        private void EditSoft_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoftForm form = new SoftForm();
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

        private void CategoryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PriceEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != ((char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
