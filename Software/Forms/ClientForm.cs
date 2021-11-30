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

        public ClientForm()
        {
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            string sql = "SElECT * FROM public.\"Client\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sql, connection.Connect);
            DataSet ds = new DataSet();
            data.Fill(ds);
            ClientView.DataSource = ds.Tables[0];
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.Show();
        }
    }
}
