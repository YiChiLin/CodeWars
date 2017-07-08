using System.Linq;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6ku
{
    [TestFixture]
    public class BingoCardTest
    {
        [Test]
        public void Has24Cards()
        {
            var target = new BingoCard();
            var result = target.GetCards();
            Assert.AreEqual(24,result.Count());
        }
    }
}
