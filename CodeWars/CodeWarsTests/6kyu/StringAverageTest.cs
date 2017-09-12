using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class StringAverageTest
    {
        [TestCase("zero nine five two", "four", TestName = "NormalCaseTest")]
        [TestCase("", "n/a", TestName = "InputString_IsEmpty_Should_Return_n_slash_a")]
        [TestCase("sixteen twenty eleven thirteen six", "n/a", TestName = "InputString_IsGreater_Than_nine_Shuld_Return_n_slash_a")]
        public void StringAverage_Test(string input, string expected)
        {
            AssertStringAverage(input, expected);
        }

        private static void AssertStringAverage(string input,string expected)
        {
            var target = new StringAverage();
            var result = target.GetAvarage(input);
            Assert.AreEqual(expected, result);
        }
    }
}
