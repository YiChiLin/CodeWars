using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyu
{
    internal class BingoCard
    {
        private Random _random = new Random();

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
                var numberInRange = Enumerable.Range(item.MinNumber, 15).ToList();
                var numberOfCards = (item.Name == "N") ? 4 : 5;
                var randomNumbers = numberInRange.OrderBy(num => _random.Next())
                                                 .Take(numberOfCards);
                cards.AddRange(randomNumbers.Select(number => item.Name + number));
            }
            return cards;
        }

        public class BingoCardColumn
        {
            public string Name { get; set;}
            public int MinNumber { get; set; }
            public int MaxNumber { get; set; }
        }
    }
}
