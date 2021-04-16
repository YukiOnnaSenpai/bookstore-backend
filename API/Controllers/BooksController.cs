using API.DAO.Classes;
using API.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IService<BookDAO> _service;

        public BooksController(IService<BookDAO> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDAO>>> GetBook()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookDAO>> GetBook(Guid id)
        {
            var book = _service.GetById(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(Guid id, BookDAO book)
        {
            if (id != book.BookID)
            {
                return BadRequest();
            }


            try
            {
                 _service.Update(book);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<BookDAO>> PostBook(BookDAO book)
        {
            _service.Add(book);

            return CreatedAtAction("GetBook", new { id = book.BookID }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BookDAO>> DeleteBook(Guid id)
        {
            _service.Delete(id);
            return NoContent();
        }

        private bool BookExists(Guid id)
        {
            if (_service.GetById(id) != null)
            {
                return true;
            }
            return false;
        }
    }
}
