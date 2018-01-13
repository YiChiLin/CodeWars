
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class MultipleOfThreeOrFiveTest
    {
        [TestCase(0, 0, TestName = "InputNumberIs_0_ShouldReturn_0")]
        [TestCase(5, 8, TestName = "InputNumberIs_5_ShouldReturn_8")]
        public void Test(int input,int expectedResult)
        {
            var target = new MultipleOfThreeOrFive();
            var actual = target.Solution(input);
            Assert.AreEqual(expectedResult, actual);
        }

    }

    public class MultipleOfThreeOrFive
    {

        public int Solution(int input)
        {
            var allNumbers = new List<int>();
            for (var i = 1; i <= input; i++)
            {
                allNumbers.Add(i);
            }

            var verifiedList = allNumbers.Where(number => number % 3 == 0 || number % 5 == 0).ToList();
            return verifiedList.Sum();
        }
    }
}
