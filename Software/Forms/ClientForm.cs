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
    public partial class ClientForm : Form
    {
        private Connection connection;
        private int CloseReason;

        public ClientForm()
        {
            CloseReason = 0;
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.Show();
            CloseReason = 1;
            Close();
        }

        private void UpdateTable()
        {
            string sql = "SElECT * FROM public.\"Client\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet ds = new DataSet();
            data.Fill(ds);
            ds.Tables[0].Columns[1].ColumnName = "Имя";
            ds.Tables[0].Columns[2].ColumnName = "Фамилия";
            ds.Tables[0].Columns[3].ColumnName = "Отчество";
            ds.Tables[0].Columns[4].ColumnName = "Номер телефона";
            ds.Tables[0].Columns[5].ColumnName = "Возраст";
            ClientView.DataSource = ds.Tables[0];
            ClientView.Columns[0].Visible = false;
            ClientView.Columns[1].Width = 140;
            ClientView.Columns[2].Width = 245;
            ClientView.Columns[3].Width = 170;
            ClientView.Columns[4].Width = 125;
            ClientView.Columns[5].Width = 50;
        }

        private void удалитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClientView.Rows[ClientView.SelectedRows.Count].Cells[0].Value);
            string sql = "DELETE FROM public.\"Client\" WHERE \"Id_client\" = '" + id + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            if (cmd.ExecuteNonQuery() == 1)
            {
                UpdateTable();
                MessageBox.Show("Клиент успешно удалён");
            }
            else
            {
                MessageBox.Show("Ошибка удаления клиента");
            }
        }

        private void ClientView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(ClientView.Rows[e.RowIndex].Cells[0].Value);
                EditClient form = new EditClient(id);
                form.Show();
                CloseReason = 1;
                Close();
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseReason == 0)
            {
                SellSoft soft = new SellSoft();
                soft.Show();
            }
            connection.CloseCon(connection.Connect);
            e.Cancel = false;
        }
    }
}
