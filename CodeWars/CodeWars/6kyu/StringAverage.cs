using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyu
{
    public class StringAverage
    {
        private readonly Dictionary<string, int> _numberStringConverter = new Dictionary<string, int>
        {
            {"zero", 0},{"one", 1},{"two", 2},{"three", 3},{"four", 4},{"five", 5},{"six", 6},{"seven", 7},{"eight", 8},{"nine", 9},
        };

        private readonly string _invaildInput = "n/a";

        public string GetAvarage(string input)
        {
            if (string.IsNullOrEmpty(input)) return _invaildInput;

            var numbers = input.Split(' ').Select(NumberConverter).AsEnumerable();
            if (numbers.Contains(-1)) return _invaildInput;
            var avarage = GetSum(numbers) / numbers.Count();
            return StringConverter(avarage);
        }

        private static int GetSum(IEnumerable<int> numbers)
        {
            return numbers.Sum();
        }

        private int NumberConverter(string key)
        {
            if (_numberStringConverter.ContainsKey(key))
                return _numberStringConverter[key];
            return -1;
        }

        private string StringConverter(int value)
        {
            return _numberStringConverter.First(converter => converter.Value == value).Key;
        }
    }
}