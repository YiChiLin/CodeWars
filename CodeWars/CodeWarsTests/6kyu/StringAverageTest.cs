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
    }

    public class StringAverage
    {
        public string GetAvarage(string input)
        {
            throw new System.NotImplementedException();
        }
    }
}
