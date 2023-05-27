using Store;

namespace Store_Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> books=new List<Book>() 
        {
            new Book(1,"ISBN 12312-31231","D. Knuth","Art of Programming"),
            new Book(2,"ISBN 12312-31232","M.Fowler","Refactoring"),
            new Book(3,"ISBN 12312-31232","B.Kernighan","C Programming Language")
        };

        public List<Book> GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToList();
        }

        public List<Book> GetAllByTitleOrAuthor(string title_partOrAuthor)
        {
            return books.Where(book => book.Author.Contains(title_partOrAuthor)||book.Title.Contains(title_partOrAuthor)).ToList();
        }
    }
}