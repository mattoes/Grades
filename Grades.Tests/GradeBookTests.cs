using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {

        [TestMethod]
        public void ComputesHighestGrade()
        {

            var book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            var result = book.ComputeStatistics();

            Assert.AreEqual(result.HighestGrade, 90);


        }


        [TestMethod]
        public void ComputesLowestGrade()
        {

            var book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            var result = book.ComputeStatistics();

            Assert.AreEqual(result.LowestGrade, 10);


        }



        [TestMethod]
        public void ComputesAverageGrade()
        {

            var book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            var result = book.ComputeStatistics();

            Assert.AreEqual(result.AverageGrade, 85.16, /*delta*/0.01);


        }


    }
}
