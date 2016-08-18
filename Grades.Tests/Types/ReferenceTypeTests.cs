using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void UsingArraysMatt()
        {
            int[] mattNumbers;
            mattNumbers = new int[5];

            mattNumbers[1] = 2;
            mattNumbers[0] = 1;

            Assert.AreEqual(2, mattNumbers[1]);
            Assert.AreEqual(1, mattNumbers[0]);


        }

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);

        }

        private void AddGrades(float[] grades)
        {
            //grades = new float[5];
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UpperCaseString()
        {
            string name = "Matt";
            name = name.ToUpper();

            Assert.AreEqual("MATT", name);
        }

        [TestMethod]
        public void AddDaysToADateTime()
        {
            var date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }


        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            var book1 = new GradeBook();
            var book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);

        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Matt";
            string name2 = "matt";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {

            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);


        }


        [TestMethod]
        public void GradebookVariablesHoldAReference()
        {
            var g1 = new GradeBook();
            var g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Matt's grade book";

            Assert.AreNotEqual(g1.Name, g2.Name);

        }
    }
}
