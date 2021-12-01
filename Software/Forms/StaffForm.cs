using System.Data;
using Npgsql;

namespace Software.Forms
{
    public partial class StaffForm : Form
    {
        private int Rows;
        private Connection connection;
        private int CloseReason;
        public StaffForm()
        {
            CloseReason = 0;
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaff form = new AddStaff();
            form.Show();
            CloseReason = 1;
            Close();
        }

        private void UpdateTable()
        {
            string sql = "SELECT * FROM public.\"Staff\"";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data.Fill(ds);
            ds.Tables[0].Columns[2].ColumnName = "Фамилия";
            ds.Tables[0].Columns[1].ColumnName = "Имя";
            ds.Tables[0].Columns[3].ColumnName = "Отчество";
            ds.Tables[0].Columns[4].ColumnName = "Номер телефона";
            StaffView.DataSource = ds.Tables[0];
            StaffView.Columns[0].Visible = false;
            StaffView.Columns[1].Width = 192;
            StaffView.Columns[2].Width = 192;
            StaffView.Columns[3].Width = 192;
            StaffView.Columns[4].Width = 142;
        }


        private void StaffView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(StaffView.Rows[e.RowIndex].Cells[0].Value);
            EditStaff form = new EditStaff(id);
            MessageBox.Show(e.RowIndex.ToString());
            form.Show();
            CloseReason = 1;
            Close();
        }

        private void удалитьВыбранногоСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Rows >= 0)
            {
                int id = Convert.ToInt32(StaffView.Rows[Rows].Cells[0].Value);
                string sql = "DELETE FROM public.\"Staff\" WHERE \"id_staff\" = '" + id + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Сотрудник успешно удалён");
                    UpdateTable();
                }
                else
                {
                    MessageBox.Show("Ошибка удаления сотрудника");
                }
                Rows = 0;
            }
        }

        private void StaffView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Rows = e.RowIndex;
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseReason == 0)
            {
                SellSoft form = new SellSoft();
                form.Show();
            }
            connection.CloseCon(connection.Connect);
            e.Cancel = false;
        }
    }
}
