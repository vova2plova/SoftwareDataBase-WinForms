using Npgsql;

namespace Software
{
    internal class Connection
    {
        public string ConnString = "Host=localhost;Username=postgres;Password=admin;Database=PO";
        public NpgsqlConnection Connect;
        public Connection()
        { 
            Connect = new NpgsqlConnection(ConnString); 
        }

        public void OpenCon(NpgsqlConnection conn)
        {
            conn.Open();
        }

        public void CloseCon(NpgsqlConnection conn)
        {
            conn.Close();
        }

    }
}
