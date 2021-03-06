using Microsoft.AspNetCore.Mvc;
using DotNetCoreAngular.Data.Services;
using DotNetCoreAngular.Data.Models;
using System;

namespace DotNetCoreAngular.Controllers
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
            try
            {
                if (book.Title != null && book.Author != null && book.Description != null) {
                    _service.AddBook(book);
                    return Ok(book);
                }
                return BadRequest("No Book was added");
            }
            catch (Exception e){
                return BadRequest(e.Message);
            }            
        }

        [HttpGet("GetBooks")]
        public IActionResult GetBooks()
        {
            var allbooks = _service.GetAllBooks();
            return Ok(allbooks);
        }

        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]Book book)
        {            
            return Ok(_service.UpdateBook(id, book));
        }

        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Ok();
        }

        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _service.GetBookById(id);
            return Ok(book);
        }
    }
}