using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {

        private List<double> grades;
        private string name;


        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
            Console.WriteLine(name);
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void getStats()
        {
            double HighGrade = double.MinValue;
            double LowGrade = double.MaxValue;
            double Avg = 0.0;

            foreach (double grade in grades)
            {
                Avg += grade;
                HighGrade = Math.Max(grade, HighGrade);
                LowGrade = Math.Min(grade, LowGrade);
            }
            Avg /= grades.Count;
            Console.WriteLine($"Highest grade is {HighGrade}");
            Console.WriteLine($"Lowest grade is {LowGrade}");
            Console.WriteLine($"Average Score is {Avg:N3}");

        }

    }

}