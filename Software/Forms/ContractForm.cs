using Npgsql;
using System.Collections;
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

        public void UpdateTable()
        {
            string sql = "Select \"Contract\".\"id_contract\", \"Client\".\"SecondName\",\"Staff\".\"SecondName\"," +
                                    " \"Contract\".\"date_contract\", \"Contract\".\"sum_price\" " +
                                    "From public.\"Contract\"" +
                                    "inner join " +
                                    "public.\"Client\" on \"Client\".\"Id_client\" = \"Contract\".\"Id_client\" " +
                                    "inner join " +
                                    "public.\"Staff\" on \"Staff\".\"id_staff\" = \"Contract\".\"id_staff\"";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet data = new DataSet();
            ad.Fill(data);
            data.Tables[0].Columns[0].ColumnName = "Номер чека";
            data.Tables[0].Columns[1].ColumnName = "Сотрудник";
            data.Tables[0].Columns[2].ColumnName = "Клиент";
            data.Tables[0].Columns[3].ColumnName = "Дата покупки";
            data.Tables[0].Columns[4].ColumnName = "Общая стоимость";
            ContractView.DataSource = data.Tables[0];
            ContractView.Columns[0].Width = 75;
            ContractView.Columns[1].Width = 200;
            ContractView.Columns[2].Width = 200;
            ContractView.Columns[3].Width = 175;
            ContractView.Columns[4].Width = 80;
        }

        private void SoftForm_Load(object sender, EventArgs e)
        {
            UpdateTable(); 
        }

        private void SoftToView(string command)
        {
            string sql = "SELECT \"Name\", \"Price\" From public.\"Soft\" Where \"id_soft\" in  (" + command + ")";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cmd);
            DataSet db = new DataSet();
            data.Fill(db);
            db.Tables[0].Columns[0].ColumnName = "Название";
            db.Tables[0].Columns[1].ColumnName = "Стоимость";
            SoftView.DataSource = db.Tables[0];
            SoftView.Columns[0].Width = 233;
            SoftView.Columns[1].Width = 233;
        }

        private void ContractView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id_contract = Convert.ToInt32(ContractView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string sql = "SELECT \"id_soft\" FROM public.\"Contract\" WHERE \"id_contract\" = '" + id_contract +"'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
                int[] Softs = new int[5];
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Softs = ((IEnumerable)reader[0]).Cast<object>()
                             .Select(x => Convert.ToInt32(x))
                             .ToArray();
                }
                reader.Close();
                int i = 0;
                string array = "";
                while (i < Softs.Length)
                {
                    if (i != 0)
                        array += ",'" + Softs[i++].ToString() + "'";
                    else
                        array += "'" + Softs[i++].ToString() + "'";
                }
                SoftToView(array);
            }
        }

        private void программноеОбеспечениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoftForm form = new SoftForm();
            form.Show();
        }

        private void продатьПрограммноеОбеспечениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellSoft form = new SellSoft();
            form.Show();
            connection.CloseCon(connection.Connect);
            this.Visible = false;
        }
    }
}