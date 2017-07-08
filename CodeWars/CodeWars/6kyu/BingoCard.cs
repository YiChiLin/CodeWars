using System;
using System.Collections.Generic;

namespace CodeWars._6kyu
{
    internal class BingoCard
    {

        public IEnumerable<string> GetCards()
        {
            var cards = new List<string>();
            var random = new Random();

            for (var index = 0; index < 24; index++)
            {
                cards.Add(random.Next(1,75).ToString());
            }

            return cards;
        }
    }
}
