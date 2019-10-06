using AddendumTask.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace AddendumTests
{
    [TestClass]
    public class ValueOperationsTests
    {
        [TestMethod]
        public void AverageValueTest()
        {
            List<Entry> entries = new List<Entry>
            {
                new Entry { Date = new DateTime(2019, 10, 1), Value = 3},
                new Entry { Date = new DateTime(2019, 10, 2), Value = 4},
                new Entry { Date = new DateTime(2019, 10, 3), Value = 7},
                new Entry { Date = new DateTime(2019, 10, 4), Value = 2},
                new Entry { Date = new DateTime(2019, 10, 5), Value = 1},
                new Entry { Date = new DateTime(2019, 10, 6), Value = 6},
                new Entry { Date = new DateTime(2019, 10, 7), Value = 10},
            };

            double expected = 4.714;

            double actual = ValueOperations.FindAverage(entries);

            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void MaxValueTest()
        {
            List<Entry> entries = new List<Entry>
            {
                new Entry { Date = new DateTime(2019, 10, 1), Value = 3},
                new Entry { Date = new DateTime(2019, 10, 2), Value = 4},
                new Entry { Date = new DateTime(2019, 10, 3), Value = 7},
                new Entry { Date = new DateTime(2019, 10, 4), Value = 2},
                new Entry { Date = new DateTime(2019, 10, 5), Value = 1},
                new Entry { Date = new DateTime(2019, 10, 6), Value = 6},
                new Entry { Date = new DateTime(2019, 10, 7), Value = 10},
            };

            int expected = 10;

            double actual = ValueOperations.FindMax(entries);

            Assert.AreEqual(expected, actual);
        }
    }
}
