using ExpectedObjects;
using NUnit.Framework;

namespace CodeWarsTests.Others
{
    [TestFixture]
    public class TwoSumTest
    {
        [TestCase(9, new int[] { 2, 7, 11, 5 })]
        public void Test(int sum, params int[] input)
        {
            var target = new TwoSum();
            var actual = target.GetSum(input,sum);
            var expected = new int[] { 0, 1 };
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }

    internal class TwoSum
    {
        internal int[] GetSum(int[] input,int expected)
        {
            for(var i = 0; i < input.Length; i++)
            {
                if( i+1 < input.Length)
                {
                    var sum = input[i] + input[i + 1];
                    if (sum == expected)
                        return new int[] { i, i + 1 };
                }
            }
            return new int[] { 0 };
        }
    }
}
