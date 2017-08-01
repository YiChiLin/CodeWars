using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class StringAverageTest
    {
        [TestCase("zero nine five two","four")]
        public void NormalCaseTest(string input,string expected)
        {
            var target = new StringAverage();
            var result = target.GetAvarage(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void InputString_IsEmpty_Should_Return_n_slash_a()
        {
            var target = new StringAverage();
            var result = target.GetAvarage("");
            Assert.AreEqual("n/a", result);
        }

        [Test]
        public void InputString_IsGreater_Than_nine_Shuld_Return_n_slash_a()
        {
            var target = new StringAverage();
            var result = target.GetAvarage("sixteen twenty eleven thirteen six");
            Assert.AreEqual("n/a", result);
        }
    }
}
