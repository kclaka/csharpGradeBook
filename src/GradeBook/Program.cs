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

            book.getStats();

        }
    }
}
