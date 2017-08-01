using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyu
{
    public class StringAverage
    {
        private readonly Dictionary<object, object> _numberStringConverter = new Dictionary<object, object>
        {
            {"zero", 0},{"one", 1},{"two", 2},{"three", 3},{"four", 4},{"five", 5},{"six", 6},{"seven", 7},{"eight", 8},{"nine", 9},
            {0, "zero"},{1, "one"},{2, "two"},{3, "three"},{4, "four"},{5, "five"},{6, "six"},{7, "seven"},{8, "eight"},{9, "nine"},
        };

        private readonly string _invaildInput = "n/a";

        public string GetAvarage(string input)
        {
            if (string.IsNullOrEmpty(input)) return _invaildInput;

            var numbers = input.Split(' ').Select(NumberStringConverter).ToList();
            if (numbers.Contains(_invaildInput)) return _invaildInput;
            var avarage = GetSum(numbers) / numbers.Count();
            return NumberStringConverter(avarage).ToString();
        }

        private static int GetSum(IEnumerable<object> numbers)
        {
            return numbers.Select(num => (int)num).Sum();
        }

        private object NumberStringConverter(object key)
        {
            return _numberStringConverter.ContainsKey(key) ? _numberStringConverter[key] : _invaildInput;
        }
    }
}