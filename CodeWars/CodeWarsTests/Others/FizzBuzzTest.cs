using CodeWars.Others;
using NUnit.Framework;

namespace CodeWarsTests.Others
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [TestCase(0,new[]{""},TestName = "Zero")]
        [TestCase(1,new[]{"1"},TestName = "One")]
        [TestCase(3,new[]{"1","2","Fizz"},TestName = "Three")]
        [TestCase(5,new[]{"1","2","Fizz","4","Buzz"},TestName = "Five")]
        [TestCase(15,new[]{"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"},TestName = "Fifteen")]
        public void Test(int input,string[] expected)
        {
            var target = new FizzBuzz();
            var result = target.GetResult(input);
            Assert.AreEqual(expected,result);
        }
    }
}
