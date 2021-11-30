using Npgsql;
using System.Data;

namespace Software.Forms
{
    public partial class ContractForm : Form
    {
        private Connection connection;
        public ContractForm()
        {
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void SoftForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM public.\"Contract\"";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet data = new DataSet();
            ad.Fill(data);
            data.Tables[0].Columns[1].ColumnName = "���������";
            data.Tables[0].Columns[2].ColumnName = "������";
            data.Tables[0].Columns[3].ColumnName = "���� �������";
            data.Tables[0].Columns[4].ColumnName = "����� ���������";
            ContractView.DataSource = data.Tables[0];
            ContractView.Columns[0].Visible = false;
        }

        private void ContractView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= ContractView.RowCount - 1)
            {
                int id_contract = Convert.ToInt32(ContractView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string sql = "SELECT \"id_soft\" FROM public.\"Contract\" WHERE \"id_contract\" = '" + id_contract +"'";
                NpgsqlDataAdapter ad = new NpgsqlDataAdapter(sql, connection.Connect);
                DataSet data = new DataSet();
                ad.Fill(data);
                SoftView.DataSource = data.Tables[0];
            }
        }

        private void ����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoftForm form = new SoftForm();
            form.Show();
        }

        private void �����������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellSoft form = new SellSoft();
            form.Show();
        }
    }
}