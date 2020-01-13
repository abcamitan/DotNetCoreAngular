using Microsoft.AspNetCore.Mvc;
using Summaries.Data;

namespace Summaries.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private IBookService  _service;

        public BookController(IBookService  service)
        {
            _service = service;
        }

        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody]Book book)
        {
            _service.AddBook(book);
            return Ok("Added");
        }

    }
}