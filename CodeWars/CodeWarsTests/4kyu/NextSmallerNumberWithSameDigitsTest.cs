using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CodeWarsTests._4kyu
{
    public class NextSmallerNumber
    {
        public long GetSmallerNumber(long num)
        {
            var numArr = num.ToString().Select(item => Convert.ToInt32(item) - 48).ToList();

            var range = numArr.Count - 1;

            //headNumber
            //bodyNumbers will be a list
            while (IsHeadNumberGreaterThanBodyNumber(numArr.GetRange(range - 1, 1)))
            {
                //swap
            }

            return 12;
        }

        private static bool IsHeadNumberGreaterThanBodyNumber(List<int> numArr)
        {
            var headNumber = numArr[numArr.Count - 2];
            var bodyNumbers = numArr[numArr.Count - 1];

            return headNumber >= bodyNumbers;
        }
    }

    [TestFixture]
    public class NextSmallerNumberWithSameDigitsTest
    {
        [Test]
        public void SimpleTest()
        {
            var target = new NextSmallerNumber();
            var result = target.GetSmallerNumber(21);
            Assert.AreEqual(12, result);
        }
    }
}