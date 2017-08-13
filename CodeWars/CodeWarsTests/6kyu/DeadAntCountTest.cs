using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class DeadAntCountTest
    {
        [TestCase("", 0, TestName = "WithEmptyString")]
        [TestCase(null, 0, TestName = "WithNullValue")]
        [TestCase("..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..", 0, TestName = "AllAliveAnt")]
        [TestCase("ant anantt aantnt", 2, TestName = "WithTwoDeadAnts")]
        public void DeadAntTest(string ants,int expected)
        {
            var target = new DeadAnt();
            var actual = target.Count(ants);
            Assert.AreEqual(expected, actual);
        }
    }
}
