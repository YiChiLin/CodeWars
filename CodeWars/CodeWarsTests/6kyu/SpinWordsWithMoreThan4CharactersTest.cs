using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class SpinWordsWithMoreThan4CharactersTest
    {
        [TestCase("World", "dlroW", TestName = "InputString_World_ShouldReturn_dlroW")]
        [TestCase("This is a test", "This is a test", TestName = "InputString_This_is_a_test_ShouldReturn_This_is_a_test")]
        [TestCase("Hey fellow warriors", "Hey wollef sroirraw", TestName = "InputString_Hey_fellow_warriors_ShouldReturn_Hey_wollef_sroirraw")]
        public void Test(string inputString, string expectedResult)
        {
            var target = new SpinWordsWithMoreThan4Characters();
            var actual = target.SpinWords(inputString);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}