using Npgsql;
using System.Text.RegularExpressions;

namespace Software.Forms
{
    public partial class EditClient : Form
    {
        Connection connection;
        int id_client;
        public EditClient(int id)
        {
            id_client = id;
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
            string sql = "SELECT * FROM public.\"Client\" WHERE \"Id_client\" = '" + id_client + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NameEdit.Text = reader[1].ToString();
                SecEdit.Text = reader[2].ToString();
                PatrEdit.Text = reader[3].ToString();
                NumberEdit.Text = reader[4].ToString();
                AgeBox.Text = reader[5].ToString();
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameEdit.Text != "" && SecEdit.Text != "" && PatrEdit.Text != "" && NumberEdit.Text != "" && AgeBox.Text != "")
            {
                string sql = "UPDATE public.\"Client\" SET \"Name\" = @NAME, \"SecondName\" = @SecondName, \"Patronymic\" = @Patronymic, \"PhoneNumber\" = @PhoneNumber, \"Age\" = Age" +
                            " WHERE \"id_client\" = '" + id_client + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.Connect);
                cmd.Parameters.AddWithValue("Name", NameEdit.Text);
                cmd.Parameters.AddWithValue("SecondName", SecEdit.Text);
                cmd.Parameters.AddWithValue("Patronymic", PatrEdit.Text);
                cmd.Parameters.AddWithValue("PhoneNumber", NumberEdit.Text);
                cmd.Parameters.AddWithValue("Age", Convert.ToInt32(AgeBox.Text));
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Изменения сохранены");
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка сохранения");
                    Close();
                }
            }
        }

        private void EditClient_FormClosing(object sender, FormClosingEventArgs e)
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
