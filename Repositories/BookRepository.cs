using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;



namespace prova_dsv_back
{
    public class BookRepository
    {
        private ApiContext _context;
        public BookRepository(ApiContext context) => _context = context;

        public List<Book> Get() => _context.Books.ToList();

        public async ValueTask<Book> AddBook(Book book) {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }
        
    }
}