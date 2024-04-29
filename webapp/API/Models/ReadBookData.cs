using System.Collections.Generic;
using MySql.Data.MySqlClient;
using API.Models.Interfaces;

namespace API.Models
{
    public class ReadBookData : IGetAllBooks, IGetBook
    {
        private string _connectionString = "server=	e11wl4mksauxgu1w.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;database=k8ixp7wd070phc60;uid=cgz9ah5rx565x86x;pwd=kjviut16uql5w8e2;";

        public List<Book> GetAllBooks()
        {
            List<Book> allBooks = new List<Book>();

            using (var con = new MySqlConnection(_connectionString))
            {
                con.Open();

                string stm = "SELECT * FROM books";
                using (var cmd = new MySqlCommand(stm, con))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            allBooks.Add(new Book() { Id = rdr.GetInt32(0), Title = rdr.GetString(1), Author = rdr.GetString(2) });
                        }
                    }
                }
            }

            return allBooks;
        }

        public Book GetBook(int id)
        {
            using (var con = new MySqlConnection(_connectionString))
            {
                con.Open();

                string stm = "SELECT * FROM books WHERE id = @id";
                using (var cmd = new MySqlCommand(stm, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Prepare();

                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        rdr.Read();
                        return new Book() { Id = rdr.GetInt32(0), Title = rdr.GetString(1), Author = rdr.GetString(2) };
                    }
                }
            }
        }
    }
}
