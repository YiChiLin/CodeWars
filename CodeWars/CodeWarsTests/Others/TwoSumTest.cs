using CodeWars.Others;
using ExpectedObjects;
using NUnit.Framework;

namespace CodeWarsTests.Others
{
    [TestFixture]
    public class TwoSumTest
    {
        [TestCase(9, new[] { 2, 7, 11, 5 })]
        public void Test(int sum, params int[] input)
        {
            var target = new TwoSum();
            var actual = target.GetSum(input,sum);
            var expected = new[] { 0, 1 };
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
