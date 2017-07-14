using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        [TestCase(0,5,1,15,TestName = "BColumnShouuldInTheRangeOf_1_to_15")]
        [TestCase(5,10,16,30,TestName = "IColumnShouuldInTheRangeOf_16_to_30")]
        [TestCase(10,14,31,45,TestName = "NColumnShouuldInTheRangeOf_31_to_45")]
        [TestCase(14,19,46,60,TestName = "GColumnShouuldInTheRangeOf_46_to_60")]
        [TestCase(19,24,61,75,TestName = "OColumnShouuldInTheRangeOf_61_to_75")]
        public void EachColumnNumberShouldInTheRange(int startIndex,int endIndex,int minNum,int maxNum)
        {
            var target = new BingoCard();
            var cards =  target.GetCards().ToList();
            var result = CheckNumberRange(startIndex, endIndex, minNum, maxNum, cards);

            Assert.AreEqual(true, result);
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

        private bool CheckNumberRange(int startIndex, int endIndex,int minNum,int maxNum, List<string> test)
        {
            var result = true;
            for (var i = startIndex ; i < endIndex; i++)
            {
                var num = int.Parse(test[i].Remove(0, 1));
                if (num < minNum || num > maxNum) result = false;
            }
            return result;
        }

        [Ignore]
        public void testFun()
        {
            // Create a byte array to hold the random value.
            byte[] randomNumber = new byte[1];

            // Create a new instance of the RNGCryptoServiceProvider. 
            RNGCryptoServiceProvider Gen = new RNGCryptoServiceProvider();

            // Fill the array with a random value.
            Gen.GetBytes(randomNumber);

            // Convert the byte to an integer value to make the modulus operation easier.
            int rand = Convert.ToInt32(randomNumber[0]);

            // Return the random number mod the number
            // of sides.  The possible values are zero-
            // based, so we add one.
            Assert.AreEqual(1,rand % 6 + 1);
        }
    }
}
