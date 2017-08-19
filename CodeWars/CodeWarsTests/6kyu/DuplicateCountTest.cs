using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class DuplicateCountTest
    {
        [TestCase("",0,TestName = "EmptyString_CountIs_0")]
        [TestCase("AB",0,TestName = "CapitalizeInput_AB_CountIs_0")]
        [TestCase("ab",0,TestName = "LowerCaseInput_ab_CountIs_0")]
        [TestCase("aabb",2,TestName = "TwoDuplicateInput_aabb_CountIs_2")]
        [TestCase("aabb1",2,TestName = "TwoDuplicateInputWithANumber_aabb1_CountIs_2")]
        [TestCase("aabb11",3,TestName = "TwoDuplicateInputWithSameNumber_aabb11_CountIs_3")]
        [TestCase("indivisibility", 1, TestName = "Input_indivisibility_CountIs_1")]
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

            return record.Count(item => item.Value > 1);
        }
    }
}
