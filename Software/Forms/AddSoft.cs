using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO public.\"Soft\" (\"Name\", \"category_soft\", \"Price\") VALUES (@Name, @category_soft, @Price)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            cmd.Parameters.AddWithValue("Name", NameEdit.Text);
            cmd.Parameters.AddWithValue("category_soft", CategoryBox.SelectedItem.ToString());
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
}
