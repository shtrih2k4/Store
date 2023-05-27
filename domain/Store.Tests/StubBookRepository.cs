using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Tests
{
    internal class StubBookRepository : IBookRepository
    {
        public List<Book> ResultOfGetAllByIsbn { get; set; }=new();
        public List<Book> ResultOfGetAllByTitleOrAuthor { get; set; } = new();
        public List<Book> GetAllByIsbn(string isbn)
        {
            return ResultOfGetAllByIsbn;
        }

        public List<Book> GetAllByTitleOrAuthor(string title_partOrAuthor)
        {
            return ResultOfGetAllByTitleOrAuthor;
        }
    }
}
