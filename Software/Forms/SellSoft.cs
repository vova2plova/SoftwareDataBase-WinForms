using System.Data;
using Npgsql;

namespace Software.Forms
{
    public partial class SellSoft : Form
    {
        private Connection connection;
        private int Rows;
        private int[] Softs;
        int CloseReason = 0;
        int count;
        public SellSoft()
        {
            CloseReason = 0;
            count = 0;
            Softs = new int[1];
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void LoadStaff()
        {
            string getStaff = "SELECT  \"SecondName\",\"Name_staff\",\"Patronymic\" FROM public.\"Staff\"";
            NpgsqlCommand getStaffcmd = new NpgsqlCommand(getStaff, connection.Connect);
            NpgsqlDataReader reader = getStaffcmd.ExecuteReader();
            while (reader.Read())
            {
                StaffBox.Items.Add(reader[0].ToString() + " " + reader[1].ToString()[0] + "." + reader[2].ToString().ToUpper()[1]);
            }
            reader.Close();
        }

        private void LoadClient()
        {
            string getClient = "SELECT \"SecondName\",\"Name\",\"Patronymic\" FROM public.\"Client\"";
            NpgsqlCommand getClientcmd = new NpgsqlCommand(getClient, connection.Connect);
            NpgsqlDataReader reader = getClientcmd.ExecuteReader();
            while (reader.Read())
            {
                ClientBox.Items.Add(reader[0].ToString() + " " + reader[1].ToString()[0] + "." + reader[2].ToString().ToUpper()[1]);
            }
            reader.Close();
        }

        private void SellSoft_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM public.\"Soft\"";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet data = new DataSet();
            ad.Fill(data);
            data.Tables[0].Columns[1].ColumnName = "Категория";
            data.Tables[0].Columns[2].ColumnName = "Стоимость";
            data.Tables[0].Columns[3].ColumnName = "Название";
            SoftView.DataSource = data.Tables[0];
            SoftView.Columns[0].Visible = false;
            SoftView.Columns[1].Width = 230;
            SoftView.Columns[2].Width = 230;
            SoftView.Columns[3].Width = 230;
            LoadStaff();
            LoadClient();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string sql = "Select * from public.\"Soft\" Where \"Name\" like '" + SearchByName.Text +"%'";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet data = new DataSet();
            ad.Fill(data);
            data.Tables[0].Columns[1].ColumnName = "Категория";
            data.Tables[0].Columns[2].ColumnName = "Стоимость";
            data.Tables[0].Columns[3].ColumnName = "Название";
            SoftView.DataSource = data.Tables[0];
            SoftView.DataSource = data.Tables[0];
            SoftView.Columns[0].Visible = false;
            SoftView.Columns[1].Width = 230;
            SoftView.Columns[2].Width = 230;
            SoftView.Columns[3].Width = 230;
        }

        private void добавитьНовогоКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.Show();
            CloseReason = 1;
            Close();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm form = new StaffForm();
            form.Show();
            CloseReason = 1;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Rows >= 0 && StaffBox.Text != "" && ClientBox.Text != "")
            {
                Array.Resize(ref Softs, count + 1);
                int id = Convert.ToInt32(SoftView.Rows[Rows].Cells[0].Value);
                Softs[count] = id;
                int i = 0;
                string array = "";
                while (i <= count)
                {
                    if (i != 0)
                        array += ",'" + Softs[i++].ToString() + "'";
                    else
                        array += "'" + Softs[i++].ToString() + "'";
                }
                string sql = "SELECT \"Name\", \"Price\" From public.\"Soft\" Where \"id_soft\" in  (" + array + ")";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
                cmd.Parameters.AddWithValue("Array", Softs);
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                ds.Tables[0].Columns[0].ColumnName = "Название";
                ds.Tables[0].Columns[1].ColumnName = "Стоимость";
                int sum = Convert.ToInt32(SumPrice.Text) + Convert.ToInt32(SoftView.Rows[Rows].Cells[2].Value);
                SumPrice.Text = (sum).ToString();
                CartView.DataSource = ds.Tables[0];
                CartView.Columns[0].Width = 200;
                CartView.Columns[1].Width = 200;
                count++;
            }
        }

        private void SoftView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Rows = e.RowIndex;
        }

        private int FindIdClient(string str)
        {
            string sql = "Select \"Id_client\" FROM public.\"Client\" WHERE \"SecondName\" = '" + str + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private int FindIdStaff(string str)
        {
            string sql = "Select \"id_staff\" FROM public.\"Staff\"WHERE \"SecondName\" = '" + str + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] staff = new string[2];
            staff = StaffBox.Text.Split(" ");
            string[] client = new string[2];
            client = ClientBox.Text.Split(" ");
            int id_staff = FindIdStaff(staff[0]);
            int id_client = FindIdClient(client[0]);
            string sql = "INSERT INTO public.\"Contract\" (\"id_staff\", \"Id_client\", \"date_contract\",\"sum_price\", \"id_soft\")" +
                "VALUES (@id_staff, @Id_client, @date_contract, @sum_price, @id_soft)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            cmd.Parameters.AddWithValue("id_staff", id_staff);
            cmd.Parameters.AddWithValue("Id_client",id_client);
            cmd.Parameters.AddWithValue("date_contract",(DateTime.Now).ToLocalTime());
            cmd.Parameters.AddWithValue("sum_price",Convert.ToInt32(SumPrice.Text));
            cmd.Parameters.AddWithValue("id_soft", Softs);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Чек успешно сохранён");
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка создания чека");
                Close();
            }
        }

        private void SellSoft_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseReason == 0)
            {
                ContractForm form = new ContractForm();
                form.Show();  
            }
            connection.CloseCon(connection.Connect);
            e.Cancel = false;
        }

        private void StaffBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
