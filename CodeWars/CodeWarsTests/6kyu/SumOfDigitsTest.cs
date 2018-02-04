using System.Collections.Generic;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class SumOfDigitsTest
    {
        [Test]
        public void SimpleTest()
        {
            var inputNumber = 123;
            var numbers = new List<int>();

            var b = inputNumber;
            while (b != 0)
            {
                var a = b % 10;
                b = b / 10;
                numbers.Add(a);
            }

            var temp = b;
        }
    }
}