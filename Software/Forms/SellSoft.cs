using System.Data;
using Npgsql;

namespace Software.Forms
{
    public partial class SellSoft : Form
    {
        private Connection connection;
        public SellSoft()
        {
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void LoadStaff()
        {
            string getStaff = "SELECT * FROM public.\"Staff\"";
            NpgsqlCommand getStaffcmd = new NpgsqlCommand(getStaff, connection.Connect);
            NpgsqlDataReader dr = getStaffcmd.ExecuteReader();
            while (dr.Read())
            {
                StaffBox.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void LoadClient()
        {
            string getClient = "SELECT * FROM public.\"Client\"";
            NpgsqlCommand getClientcmd = new NpgsqlCommand(getClient, connection.Connect);
            NpgsqlDataReader dreader = getClientcmd.ExecuteReader();
            while (dreader.Read())
            {
                StaffBox.Items.Add(dreader[0]);
            }
            dreader.Close();
        }

        private void SellSoft_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM public.\"Soft\"";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet data = new DataSet();
            ad.Fill(data);
            SoftView.DataSource = data.Tables[0];
            SoftView.AllowUserToResizeRows = false;
            LoadStaff();
            LoadClient();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string sql = "Select * from public.\"Soft\" Where \"Name\" like '" + SearchByName.Text +"%'";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet data = new DataSet();
            ad.Fill(data);
            SoftView.DataSource = data.Tables[0];
            SoftView.AllowUserToResizeRows = false;
        }

        private void добавитьНовогоКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.Show();
        }
    }
}
