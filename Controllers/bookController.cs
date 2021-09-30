using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace prova_dsv_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        BookRepository _repo;
        public BookController(BookRepository repo) => _repo = repo;

        [HttpGet]
        public List<Book> Get() => _repo.Get();

        [HttpPost]
        public async ValueTask<Book> List(Book book) => await _repo.AddBook(book);
    }
}
