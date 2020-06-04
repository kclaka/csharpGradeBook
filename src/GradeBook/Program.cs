using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("====SBCC Grade Book====");
            book.AddGrade(45.1);
            book.AddGrade(50);
            book.AddGrade(95);
            book.AddGrade(23);
            book.AddGrade(80.6);

            var result = book.GetStatistics();

            Console.WriteLine($"Highest grade is {result.High}");
            Console.WriteLine($"Lowest grade is {result.Low}");
            Console.WriteLine($"Average Score is {result.Average:N1}");

        }
    }
}
