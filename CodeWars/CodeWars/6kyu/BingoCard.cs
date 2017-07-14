using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace CodeWars._6kyu
{
    internal class BingoCard
    {
        //RNGCryptoServiceProvider 
        //private Random _random = new Random();
        private RNGCryptoServiceProvider _random = new RNGCryptoServiceProvider();
        public IEnumerable<string> GetCards()
        {
            var cards = new List<string>();
            var column = new List<BingoCardColumn>
            {
                new BingoCardColumn {Name = "B", MinNumber = 1, MaxNumber = 15},
                new BingoCardColumn {Name = "I", MinNumber = 16, MaxNumber = 30},
                new BingoCardColumn {Name = "N", MinNumber = 31, MaxNumber = 45},
                new BingoCardColumn {Name = "G", MinNumber = 46, MaxNumber = 60},
                new BingoCardColumn {Name = "O", MinNumber = 61, MaxNumber = 75}
            };

            foreach (var item in column)
            {
                var numbers = new List<int>();
                var numberOfCards = (item.Name == "N") ? 4 : 5;
                for (var i = 0; i < numberOfCards; i++)
                {
                    var number = GenerateRandomNumber(item.MinNumber, item.MaxNumber);
                    while (numbers.Contains(number))
                    {
                        number = GenerateRandomNumber(item.MinNumber, item.MaxNumber);                        
                    }
                    numbers.Add(number);
                    cards.Add(item.Name + number);
                }
            }
            return cards;
        }

        private int GenerateRandomNumber(int minNum,int maxNum)
        {
            var randomNumber = new byte[1];
            _random.GetBytes(randomNumber);
            var value = Convert.ToInt32(randomNumber[0]);
            return value % (maxNum - minNum + 1) + minNum;
        }
    }

    public class BingoCardColumn
    {
        public string Name { get; set; }
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
    }
}
