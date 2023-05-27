using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface IBookRepository
    {
        public List<Book> GetAllByTitleOrAuthor(string title_partOrAuthor);
        public List<Book> GetAllByIsbn(string isbn);
    }
}
