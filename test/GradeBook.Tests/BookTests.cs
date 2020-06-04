using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {

            Book book = new Book("");

            //arrange
            book.AddGrade(90.3);
            book.AddGrade(43.6);
            book.AddGrade(45.6);
            book.AddGrade(21.4);


            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(90.3, result.High);
            Assert.Equal(50.2, result.Average, 1);
            Assert.Equal(21.4, result.Low, 1);



        }
    }
}
