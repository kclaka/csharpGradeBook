using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        private List<double> grades;
        public string Name;


        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
            Console.WriteLine(name);
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            Statistics stat = new Statistics();
            stat.High = double.MinValue;
            stat.Low = double.MaxValue;


            foreach (double grade in grades)
            {
                stat.Average += grade;
                stat.High = Math.Max(grade, stat.High);
                stat.Low = Math.Min(grade, stat.Low);
            }
            stat.Average /= grades.Count;

            return stat;

        }

    }

}