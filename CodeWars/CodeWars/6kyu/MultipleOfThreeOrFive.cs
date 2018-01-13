using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyu
{
    public class MultipleOfThreeOrFive
    {

        public int Solution(int input)
        {
            var allNumbers = GenerateAllNumbers(input);
            var verifiedList = allNumbers.Where(number => number % 3 == 0 || number % 5 == 0).ToList();
            return verifiedList.Sum();
        }

        public int Solution2(int input)
        {
            return Enumerable.Range(1, input).Where(number => number % 3 == 0 || number % 5 == 0).Sum();
        }

        private static IEnumerable<int> GenerateAllNumbers(int input)
        {
            var allNumbers = new List<int>();
            for (var i = 1; i < input; i++)
            {
                allNumbers.Add(i);
            }
            return allNumbers;
        }
    }
}
