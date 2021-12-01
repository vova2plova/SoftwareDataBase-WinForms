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
    public partial class AddSoft : Form
    {
        private Connection connection;
        public AddSoft()
        {
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void AddSoft_Load(object sender, EventArgs e)
        {
            CategoryBox.Items.Add("Графический редактор");
            CategoryBox.Items.Add("Редактор кода");
            CategoryBox.Items.Add("Электронные таблицы");
            CategoryBox.Items.Add("СУБД");
            CategoryBox.Items.Add("Видеоредактор");
            CategoryBox.Items.Add("Аудиоредактор");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameEdit.Text != "" && CategoryBox.Text != "" && PriceEdit.Text != "")
            {
                string sql = "INSERT INTO public.\"Soft\" (\"Name\", \"category_soft\", \"Price\") VALUES (@Name, @category_soft, @Price)";
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
                    Close();
                }
            }
        }

        private void AddSoft_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoftForm form = new SoftForm();
            form.Show();
        }

        private void NameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != ((char)Keys.Back)) && e.KeyChar != ((char)Keys.Space))
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
