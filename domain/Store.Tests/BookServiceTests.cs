using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Store.Tests
{
    public class BookServiceTests
    {
        [Fact]
        public void GetAllByQuery_WithIsbn_CallsGetAllByIsbn()
        {
            var bookRepositoryStub = new Mock<IBookRepository>();
            bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>())).Returns(
                new List<Book>{ new Book(1, "", "", "")});
            bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>())).Returns(
                new List<Book> { new Book(2, "", "", "") }
                );
            var bookService = new BookService(bookRepositoryStub.Object);
            var actual = bookService.GetAllByQuery("ISBN 12345-67890");
            Assert.Collection(actual, book => Assert.Equal(1, book.Id));

        }
        [Fact]
        public void GetAllByQuery_WithAuthor_CallsGetAllByAuthor()
        {
            var bookRepositoryStub = new Mock<IBookRepository>();
            bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>())).Returns(
                new List<Book> { new Book(1, "", "", "") });
            bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>())).Returns(
                new List<Book> { new Book(2, "", "", "") }
                );
            var bookService = new BookService(bookRepositoryStub.Object);
            var actual = bookService.GetAllByQuery("IS 12345-67890");
            Assert.Collection(actual, book => Assert.Equal(2, book.Id));
        }
    }
}
