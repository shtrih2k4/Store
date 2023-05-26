using Store;

namespace Store_Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> books=new List<Book>() 
        {
            new Book(1,"Art of Programming"),
            new Book(2,"Refactoring"),
            new Book(3,"C Programming Language")
        };
        public List<Book> GetAllByTitle(string title_part)
        {
            return books.Where(book => book.Title.Contains(title_part)).ToList();
        }
    }
}