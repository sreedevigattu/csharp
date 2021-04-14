using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(10.0);
            book.AddGrade(20.0);
            book.AddGrade(30.0);

            // act
            var result = book.GetStats();

            // assert
            Assert.Equal(20.0, result.Average);
            Assert.Equal(30.0, result.High);
            Assert.Equal(10.0, result.Low);
        }
    }
}
