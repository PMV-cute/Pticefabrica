using Npgsql;

namespace Pticefabrica
{
    class ConnectionBD
    {
        NpgsqlConnection connect = new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=maksimka09;Database=DB;");
        public void OpenConn()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        public void CloseConn()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
        public NpgsqlConnection GetConnect()
        {
            return connect;
        }
    }
}
