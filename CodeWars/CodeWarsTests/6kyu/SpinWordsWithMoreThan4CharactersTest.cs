using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class SpinWordsWithMoreThan4CharactersTest
    {
        [TestCase("World", "dlroW", TestName = "InputString_World_ShouldReturn_dlroW")]
        public void Test(string inputString, string expectedResult)
        {
            var target = new SpinWordsWithMoreThan4Characters();
            var actual = target.SpinWords(inputString);
            Assert.AreEqual(expectedResult, actual);
        }
    }

    public class SpinWordsWithMoreThan4Characters
    {
        public string SpinWords(string inputString)
        {
            var separatedWords = inputString.Split(' ').ToList();
            var formatWords = separatedWords.Select(word => word.Length >= 5 ? string.Join("", word.ToCharArray().Reverse()) : word).ToList();
            return string.Join(" ", formatWords);
        }
    }
}