using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class PrimString
    {
        
        [Test]
        public void Give_abcd_should_be_true()
        {
            var target = new PrimeString();
            var result = target.IsPrimeString("abcd");

            Assert.AreEqual(true, result);
        }
    }

    internal class PrimeString
    {
        public bool IsPrimeString(string str)
        {
            throw new System.NotImplementedException();
        }
    }
}
