using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLibrary.Models;
using ApiLibrary.Service.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiLibrary.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService BookService;

        public BookController(IBookService bookService)
        {
            this.BookService = bookService;
        }

        // GET: api/values
        [HttpGet]
        public List<Book> Get()
        {
            return BookService.ListAllBooks();
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost("Add")]
        public ActionResult<bool> Post([FromBody]Book book)
        {
            if (book != null && book.Category != null)
            {

                BookService.AddBook(book);
                return true;
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
