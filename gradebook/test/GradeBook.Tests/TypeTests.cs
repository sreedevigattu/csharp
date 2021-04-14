using System;
using Xunit;


namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDiffObjects()
        {
            // arrange
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            // act

            // assert
            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);
        }

        [Fact]
        public void TwoVarsReferenceSameObjects()
        {
            // arrange
            var book1 = GetBook("Book1");
            var book2 = book1;

            // act

            // assert
            Assert.Same(book1, book2);

        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange
            var book1 = GetBook("Book1");
            SetName(book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        private Book GetBook(string name)
        {
            return new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // arrange
            var book1 = GetBook("Book1");
            GetBookSetName(book1, "New Name");

            // assert
            Assert.Equal("Book1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByRef()
        {
            var book1 = GetBook("Book1");
            GetBookSetName(ref book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void Test()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(4, x);
        }

        private int GetInt()
        {
            return 3;
        }

        private void SetInt(ref int i)
        {
            i = 4;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            var name = "Sree";
            var upperName = MakeUpper(name);
            Assert.Equal("Sree", name);
            Assert.Equal("SREE", upperName);
        }

        private string MakeUpper(string val)
        {
            return val.ToUpper();
        }
    }
}
