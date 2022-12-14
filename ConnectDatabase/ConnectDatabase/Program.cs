
using MySql.Data.MySqlClient;

namespace ConnectDatabase
{

    public class Ketnoi
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "zalo";
            string username = "root";
            string password = "123456";
            return CauHinh.GetDBConnection(host, port, database, username, password);
        }
    }
    public class CauHinh
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            /* Chuỗi kết nối trong thư viện MySql.Data.dll

            String connString = "Server=" + host + ";Database=" + database

                + ";port=" + port + ";User Id=" + username + ";password=" + password;*/

            String connString = "Server=" + host + ";Database=" + database + ";User=" + username
                + ";Port=" + port + ";Password=" + password + ";charset=utf8;SslMode=REQUIRED";


            String connetionString = "datasource="+ host+";port="+port+";username="+ username + ";password="+ password;


            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
