using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            var stats = new GradeStatistics();

            float sumGrades = 0;

            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sumGrades += grade;
            }
            stats.AverageGrade = sumGrades / grades.Count;
            return stats;
        }



        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades;

    }
}
