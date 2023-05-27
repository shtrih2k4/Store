
using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public int Id { get; }
        public string Title { get;} = null!;
        public string? Isbn { get; }
        public string Author { get; } = null!;
        public Book(int id,string isbn,string author,string title)
        {
            Id = id;
            Isbn= isbn;
            Author = author;
            Title = title;
        }
       internal static bool IsIsbn(string? query)
        {
            if (query is null) return false;
            query = query.Replace("-", "").Replace(" ", "").ToUpper();
            return Regex.IsMatch(query, @"^ISBN\d{10}(\d{3})?$");
        }
    }
}