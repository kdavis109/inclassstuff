using MySql.Data.MySqlClient;
using api.Data;

namespace api.Models
{
    public class Book
    {
         public string Title{get; set;}

         public string Author{get; set;}

         public static List<Book> GetAllBooks() {
            List<Book> myBooks = new List<Book>(); // create new book list
             Database database = new Database(); // get object for database class
             using var con = database.GetPublicConnection(); //get connection form method 
            //string cs= "server=vhw3t8e71xdz9k14.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;user=ceae4i3or44asv7i;database=zsubvtviu1wtkjd6;port=3306;password=xrvyc9ju3sd3hdu1";
            //using var con = new MySqlConnection(cs);
            con.Open();//open connect
        
            string stm = "Select * from Books"; //sql statement
             MySqlCommand cmd = new MySqlCommand(stm, con); // new sql command

             using MySqlDataReader rdr = cmd.ExecuteReader(); // new sql reader

               while (rdr.Read()){ //loop through database and add to list of books
               myBooks.Add(new Book(){Title = rdr.GetString(1), Author = rdr.GetString(2)});
              }
              return myBooks; // return 

         }
    }
}
