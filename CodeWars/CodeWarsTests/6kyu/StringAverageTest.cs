using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class StringAverageTest
    {
        [TestCase("zero nine five two","four")]
        public void NormalCaseTest(string input,string expected)
        {
            var target = new StringAverage();
            var result = target.GetAvarage(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void InputString_IsEmpty_Should_Return_n_slash_a()
        {
            var target = new StringAverage();
            var result = target.GetAvarage("");
            Assert.AreEqual("n/a", result);
        }

        [Test]
        public void InputString_IsGreater_Than_nine_Shuld_Return_n_slash_a()
        {
            var target = new StringAverage();
            var result = target.GetAvarage("sixteen twenty eleven thirteen six");
            Assert.AreEqual("n/a", result);
        }
    }

    public class StringAverage
    {
        private readonly Dictionary<object, object> _numberStringConverter = new Dictionary<object, object>
        {
            {"zero", 0},{"one", 1},{"two", 2},{"three", 3},{"four", 4},{"five", 5},{"six", 6},{"seven", 7},{"eight", 8},{"nine", 9},
            {0, "zero"},{1, "one"},{2, "two"},{3, "three"},{4, "four"},{5, "five"},{6, "six"},{7, "seven"},{8, "eight"},{9, "nine"},
        };

        public string GetAvarage(string input)
        {
            var invaildInput = "n/a";
            if (string.IsNullOrEmpty(input)) return invaildInput;

            var numbers = input.Split(' ').Select(NumberStringConverter).ToList();
            if (numbers.Contains(invaildInput)) return invaildInput;
            var avarage = GetSum(numbers) / numbers.Count();
            return NumberStringConverter(avarage).ToString();
        }

        private static int GetSum(IEnumerable<object> numbers)
        {
            return numbers.Select(item=>(int)item).Sum();
        }

        private object NumberStringConverter(object key)
        {
            return _numberStringConverter.ContainsKey(key) ? _numberStringConverter[key] : "n/a";
        }
    }
}
