using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.1f);
            book.AddGrade(75);

            var stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);


        }
    }
}
