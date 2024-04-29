using MySql.Data.MySqlClient;

string cs= "server=vhw3t8e71xdz9k14.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;user=ceae4i3or44asv7i;database=zsubvtviu1wtkjd6;port=3306;password=xrvyc9ju3sd3hdu1";
using var con = new MySqlConnection(cs);
con.Open();

string stm = "SELECT * FROM Books";
using var cmd = new MySqlCommand(stm, con);

using MySqlDataReader rdr = cmd.ExecuteReader();

while (rdr.Read()){
     Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)}{rdr.GetString(2)}");
}



