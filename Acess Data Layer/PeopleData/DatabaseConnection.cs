using System.Data.SqlClient;


namespace Project_Driver_License_management
{
    public static class DatabaseConnection
    {
        private static readonly string Str_Connection =
            "Server=.;Database=DVLD;User ID=sa;Password=123456;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(Str_Connection);
        }
    }
}
