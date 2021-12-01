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
    public partial class SoftForm : Form
    {
        private Connection connection;
        private int Rows;
        public SoftForm()
        {
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void SoftForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void добавитьПОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSoft form = new AddSoft();
            form.Show();
            connection.CloseCon(connection.Connect);
            Close();
        }

        private void SoftView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(SoftView.Rows[e.RowIndex].Cells[0].Value);
                EditSoft form = new EditSoft(id);
                form.Show();
                connection.CloseCon(connection.Connect);
                Close();
            }
        }

        private void UpdateTable()
        {
            string sql = "SELECT * FROM public.\"Soft\"";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet data = new DataSet();
            ad.Fill(data);
            data.Tables[0].Columns[1].ColumnName = "Категория";
            data.Tables[0].Columns[2].ColumnName = "Стоимость";
            data.Tables[0].Columns[3].ColumnName = "Название";
            SoftView.DataSource = data.Tables[0];
            SoftView.AllowUserToResizeRows = false;
            SoftView.Columns[0].Visible = false;
            SoftView.Columns[1].Width = 245;
            SoftView.Columns[2].Width = 245;
            SoftView.Columns[3].Width = 245;
        }

        private void удалитьПОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Rows >= 0)
            {
                int id = Convert.ToInt32(SoftView.Rows[Rows].Cells[0].Value.ToString());
                string sql = "DELETE FROM public.\"Soft\" WHERE \"id_soft\" = '" + id + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Успешно удалено");
                    UpdateTable();
                }
                else
                {
                    MessageBox.Show("Ошибка удаления");
                    Close();
                }
            }
            else
                MessageBox.Show("Ошибка");
        }

        private void SoftView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Rows = e.RowIndex;
        }

    }
}
