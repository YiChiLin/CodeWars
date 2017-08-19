using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class DuplicateCountTest
    {
        [TestCase("AB",0,TestName = "CapitalizeInput_AB_CountIs_0")]
        public void Test(string input,int expected)
        {
            var target = new DuplicateCount();
            var actual = target.GetCount(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class DuplicateCount
    {
        public int GetCount(string input)
        {
            input = input.ToLower();
            var record = new Dictionary<char,int>();

            foreach (var character in input)
            {
                if (record.ContainsKey(character))
                    record[character] += 1;
                else
                    record.Add(character, 1);
            }

            return record.Count(x => x.Value > 1);
        }
    }
}
