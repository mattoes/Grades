using System;
using System.Collections.Generic;
using System.IO;
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
            name = "Empty";
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (name != (value))
                {
                    var args = new NameChangedEventArgs();
                    args.ExistingName = name;
                    args.NewName = value;

                    NameChanged(this, args);
                }
                name = value;

            }

        }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i - 1]);
            }
        }

        public event NameChangedDelegate NameChanged;

        private string name;
        private List<float> grades;


        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            var stats = new GradeStatistics();

            float sumGrades = 0;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sumGrades += grade;
            }
            stats.AverageGrade = sumGrades / grades.Count;
            return stats;
        }



    }
}
