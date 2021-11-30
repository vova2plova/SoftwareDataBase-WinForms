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
            Close();
        }

        private void SoftView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(SoftView.Rows[e.RowIndex].Cells[0].Value);
            EditSoft form = new EditSoft(id);
            form.Show();
            Close();
        }

        private void UpdateTable()
        {
            string sql = "SELECT * FROM public.\"Soft\"";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet data = new DataSet();
            ad.Fill(data);
            SoftView.DataSource = data.Tables[0];
            SoftView.AllowUserToResizeRows = false;
        }

        private void удалитьПОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(SoftView.Rows[SoftView.SelectedRows.Count].Cells[0].Value.ToString());
            string sql = "DELETE FROM public.\"Soft\" WHERE \"id_soft\" = '" + id +"'";
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
    }
}
