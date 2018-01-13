using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class MultipleOfThreeOrFiveTest
    {
        [TestCase(0, 0, TestName = "InputNumberIs_0_ShouldReturn_0")]
        [TestCase(5, 3, TestName = "InputNumberIs_5_ShouldReturn_3")]
        [TestCase(10, 23, TestName = "InputNumberIs_10_ShouldReturn_23")]
        public void Test(int input,int expectedResult)
        {
            var target = new MultipleOfThreeOrFive();
            var actual = target.Solution(input);
            Assert.AreEqual(expectedResult, actual);
        }

    }
}
