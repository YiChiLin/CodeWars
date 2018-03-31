using NUnit.Framework;

namespace CodeWarsTests._5kyu
{
    [TestFixture]
    public class RunnersMeetingsTest
    {
        [TestCase(new[] { 1, 4, 2 }, new[] { 27, 18, 24 }, ExpectedResult = 3)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 1, 1 }, ExpectedResult = -1)]
        [TestCase(new[] { -23, -2 }, new[] { 25, 27 }, ExpectedResult = -1)]
        [TestCase(new[] { 1, 1000 }, new[] { 23, 22 }, ExpectedResult = 2)]
        [TestCase(new[] { 1, 4, 2 }, new[] { 5, 6, 2 }, ExpectedResult = 2)]
        [TestCase(new[] { -41, 2, 10 }, new[] { 18, 27, 26 }, ExpectedResult = 2)]

        public int SimpleTest(int[] startPosition, int[] speedsPerMinute)
        {
            var target = new RunnersMeetings();
            return target.GetMeetingCardinality(startPosition, speedsPerMinute);
        }
    }
}