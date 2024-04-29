using MySql.Data.MySqlClient;

namespace api.Data
{
    public class Database
    {
        private string server = "vhw3t8e71xdz9k14.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
        private string port = "3306";
        private string username = "ceae4i3or44asv7i";
        private string password = "xrvyc9ju3sd3hdu1";
        private string schema = "zsubvtviu1wtkjd6";

     public MySqlConnection GetPublicConnection(){
            string cs= $"server={server};user={username};database={schema};port={port};password={password}";
             var con = new MySqlConnection(cs);
           return con;

     }
    }
}