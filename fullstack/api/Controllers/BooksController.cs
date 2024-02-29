using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET: api/Books
        [HttpGet]
        public List<Book> Get()
        {
            List<Book> myBooks = new List<Book>();
            myBooks.Add(new Book(){Title = "Mistborn", Author = "Brandon Sanderson"});
            myBooks.Add(new Book(){Title = "Chronicles of Narnia", Author = "C. S. Lewis"});
            return myBooks;
        }

        // GET: api/Books/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Books
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
