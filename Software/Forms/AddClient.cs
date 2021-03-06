using Npgsql;
using System.Text.RegularExpressions;

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
            AgeBox.Text = "12";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameEdit.Text != "" && SecEdit.Text != "" && PatrEdit.Text != "" && NumberEdit.Text != "" && AgeBox.Text != "")
            {
                string sql = "INSERT INTO public.\"Client\" (\"Name\", \"SecondName\", \"Patronymic\", \"PhoneNumber\", \"Age\") VALUES (@Name, @SecondName, @Patronymic, @PhoneNumber, @Age)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
                cmd.Parameters.AddWithValue("Name", NameEdit.Text);
                cmd.Parameters.AddWithValue("SecondName", SecEdit.Text);
                cmd.Parameters.AddWithValue("Patronymic", PatrEdit.Text);
                cmd.Parameters.AddWithValue("PhoneNumber", NumberEdit.Text);
                cmd.Parameters.AddWithValue("Age", Convert.ToInt32(AgeBox.Text));
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Клиент добавлен");
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка добавления");
                    Close();
                }
            }
        }

        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientForm form = new ClientForm();
            form.Show();
            connection.CloseCon(connection.Connect);
        }

        private void SecEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != ((char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void AgeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
