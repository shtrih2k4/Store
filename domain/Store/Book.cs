
namespace Store
{
    public class Book
    {
        public uint Id { get; }
        public string Title { get;} = null!;
        public Book(uint id,string title)
        {
            Id = id;
            Title = title;
        }

    }
}