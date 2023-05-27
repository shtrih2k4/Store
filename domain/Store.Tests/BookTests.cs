namespace Store.Tests
{
    public class BookTests

    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual=Book.IsIsbn(null);
            Assert.False(actual);

        }
        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");
            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_With10numbers_ReturnTrue()
        {
            bool actual = Book.IsIsbn("ISBN 123-456-789 0");

            Assert.True(actual);
        }
        [Fact]
        public void IsIsbn_With13Numbers_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123-456-789 0123");
            Assert.True(actual);
        }
        [Fact]
        public void IsIsbn_WithTrashStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("asasasass isbn 12345-6789-098");
            Assert.False(actual);
        }
    }
}