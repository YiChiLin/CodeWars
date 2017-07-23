using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class PrimStringTest
    {
        [TestCase("abcd",true,TestName = "abcd_should_be_true")]
        [TestCase("abab",false,TestName = "abab_should_be_false")]
        public void IsPrimeStringTest(string str, bool expected)
        {
            var target = new PrimeString();
            var result = target.IsPrimeString(str);

            Assert.AreEqual(expected, result);
        }
    }

    internal class PrimeString
    {
        public bool IsPrimeString(string str)
        {
            for (var start = 0; start < str.Length; start++)
            {
                var frontCompositionLength = start + 1;
                if (frontCompositionLength < str.Length)
                {
                    var frontComposition = str.Substring(start, frontCompositionLength - start);
                    var backCompositionLength = str.Length - (frontCompositionLength + 1);
                    var backComposition = str.Substring(frontCompositionLength + 1, backCompositionLength);
                    if (frontComposition == backComposition)
                        return false;
                }
            }
            return true;
        }
    }
}
