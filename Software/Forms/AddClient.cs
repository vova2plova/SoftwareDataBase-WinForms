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
    public partial class AddClient : Form
    {
        Connection connection;
        public AddClient()
        {
            connection = new Connection();
            connection.OpenCon(connection.Connect);
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            int i = 12;
            while (i <= 99)
                AgeBox.Items.Add(i++);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO piblic.\"Client\" () VALUES ()";
        }
    }
}
