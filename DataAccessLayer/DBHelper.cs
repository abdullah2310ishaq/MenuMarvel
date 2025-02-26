using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EF8FTPP\\SQLEXPRESS01;Initial Catalog=MenuMarvel;Integrated Security=True");
            return con;
        }
    }
}