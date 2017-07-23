using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class PrimStringTest
    {
        [TestCase("abcd",true,TestName = "abcd_should_be_true")]
        [TestCase("abab",false,TestName = "abab_should_be_false")]
        [TestCase("x", true, TestName = "x_should_be_true")]
        [TestCase("fdsyffdsyffdsyffdsyffdsyf", false, TestName = "fdsyffdsyffdsyffdsyffdsyf_should_be_false")]
        [TestCase("utdutdtdutd", true, TestName = "utdutdtdutd_should_be_false")]
        public void IsPrimeStringTest(string str, bool expected)
        {
            var target = new PrimeString();
            var result = target.IsPrimeString(str);
            Assert.AreEqual(expected, result);
        }
    }
}
