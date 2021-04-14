using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            this.Name = name;
            this.grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStats()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            return result;
        }
        private List<double> grades;
        public string Name;
    }
}