using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store;

namespace Store
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookService)
        {
            this._bookRepository = bookService;
        }
        public List<Book> GetAllByQuery(string query) {
            if (Book.IsIsbn(query))
                return _bookRepository.GetAllByIsbn(query);
            return _bookRepository.GetAllByTitleOrAuthor(query);
        }
    }
}
