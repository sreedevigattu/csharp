using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sree's grade book");
            book.AddGrade(10.0);
            book.AddGrade(20.0);
            book.AddGrade(30.0);
            //book.ShowStats();
            book.GetStats();

            /*
            double[] numbers = new[] {10.0, 20.0, 30.0};
            var grades = new List<double>() {10.0, 20.0, 30.0};
            grades.Add(10.0);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result = result/grades.Count;
            
            Console.WriteLine($"Average of grades: {result:N2}");
            */
            //Console.WriteLine($"Hello {args[0]}!");
        }
    }
}
