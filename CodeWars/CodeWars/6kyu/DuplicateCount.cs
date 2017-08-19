using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyu
{
    public class DuplicateCount
    {
        public int GetCount(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var record = new Dictionary<char,int>();

            foreach (var character in input.ToLower())
            {
                if (record.ContainsKey(character))
                    record[character] += 1;
                else
                    record.Add(character, 1);
            }

            return record.Count(item => item.Value > 1);
        }
    }
}