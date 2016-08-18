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

            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            book.AddGrade(91);
            book.AddGrade(89.1f);
            book.AddGrade(75);
            book.WriteGrades(Console.Out);

            var stats = book.ComputeStatistics();
            WriteResult("Average grade", stats.AverageGrade);
            WriteResult("Highest grade", stats.HighestGrade);
            WriteResult("Lowest grade", stats.LowestGrade);
            WriteResult("Grade: " + stats.Description, stats.LetterGrade);



        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}", description, result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }
    }
}
