using System.Collections.Generic;

namespace tests
{
    using ConsoleApplication1;

    using NUnit.Framework;

    [TestFixture]
    public class uniqueNumberTests
    {

        [TestCase(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4 }, Result = 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 1, 2, 3, 4 }, Result = -1)]
        [TestCase(new int[] {}, Result = -1)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, Result = -1)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 6}, Result = 6)]
        [TestCase(new int[] { 6, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, Result = 6)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1 }, Result = 0)]
        public int SimpleNumbers(int[] A)
        {
            var underTest = new Uniqueness();
            return underTest.findUniqueItem(A);
        }
      
        [TestCase(1000, Result = 1)]
        [TestCase(10000, Result = 1)]
        [TestCase(100000, Result = 1)]
        [TestCase(1000000, Result = 1)]
        [TestCase(10000000, Result = 1)]
        [TestCase(100000000, Result = 1)]
        //[TestCase(1000000000, Result = 1)] // Turns out an Int[] can't handle 1,000,000,000 items, the max is 268435456
        public int LargeAllUniqueNumbers(int count)
        {
            int[] A;

            var items = new List<int>();

            for (int i = 1; i < count; i++)
            {
                items.Add(i);
            }

            A = items.ToArray();

            var underTest = new Uniqueness();
            return underTest.findUniqueItem(A);            
        }

        /// <summary>
        /// Test a large number
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        [TestCase(1000, Result = -1)]
        [TestCase(10000, Result = -1)]
        [TestCase(100000, Result = -1)]
        [TestCase(1000000, Result = -1)]
        [TestCase(10000000, Result = -1)]
        [TestCase(100000000, Result = -1)]
        // [TestCase(1000000000, Result = -1)] // Turns out an Int[] can't handle 1,000,000,000 items, the max is 268435456
        public int LargeNonUniqueNumbers(int count)
        {
            int[] A;

            var items = new List<int>();

            for (int i = 1; i < count; i++)
            {
                items.Add(2);
            }

            A = items.ToArray();

            var underTest = new Uniqueness();
            return underTest.findUniqueItem(A);
        }

    }
}
