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

        [Test]
        public void Has24UniqueCards()
        {
            var target = new BingoCard();
            var result = target.GetCards();
            Assert.AreEqual(result.Count(), result.Distinct().Count());
        }

        [Test]
        public void RandomnessTest()
        {
            var target = new BingoCard().GetCards().ToArray();
            var duplicateCardNumberCount = (new int[24]).ToList();

            for (var cardSet = 0; cardSet < 100; cardSet++)
            {
                var randomCard = new BingoCard().GetCards().ToArray();
                for (var j = 0; j < 24; j++)
                {
                    if (target[j] == randomCard[j])
                    {
                        duplicateCardNumberCount[j]++;
                    }
                }
            }

            Assert.IsFalse(duplicateCardNumberCount.Any(x => x > 30), "The same number appeared on more than 30 of the 100 cards on the same spot, are the cards random?");
        }
    }
}
