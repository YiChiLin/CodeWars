using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class AccumulTest
    {
        //Mumbling
        [Test]
        public void Accumlate_A_and_Will_Get_A()
        {
            var target = new Accumul();
            var result = target.Accum("A");
            Assert.AreEqual("A",result);
        }

        [TestCase("AB","A-Bb")]
        public void Accumlate(string input,string expected)
        {
            var target = new Accumul();
            var result = target.Accum(input);
            Assert.AreEqual(expected, result);
        }
    }
}
