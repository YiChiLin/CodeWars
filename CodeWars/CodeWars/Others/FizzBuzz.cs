using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Others
{
    internal class FizzBuzz
    {
        public string[] GetResult(int input)
        {
            if (input == 0) return new[] { "" };

            var allNumber = new List<int>();
            for (var i = 1; i <= input; i++)
            {
                allNumber.Add(i);
            }

            var result = allNumber.Select(x =>
            {
                var str = (x%3 == 0 ? "Fizz" : "") + (x%5 == 0 ? "Buzz" : "");
                return string.IsNullOrEmpty(str) ? x.ToString() : str;
            });
            return result.ToArray();
        }
    }
}