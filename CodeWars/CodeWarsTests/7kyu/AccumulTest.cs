using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class AccumulTest
    {
        //Mumbling
        [Test]
        public void Accumlate_A_Should_Return_A()
        {
            AccumlateShouldBe("A","A");
        }

        [Test]
        public void Accumlate_AB_Should_Return_A_Dash_Bb()
        {
            AccumlateShouldBe("AB","A-Bb");
        }

        [Test]
        public void Accumlate_Ab_Should_Return_A_Dash_Bb()
        {
            AccumlateShouldBe("Ab", "A-Bb");
        }

        public void AccumlateShouldBe(string input,string expected)
        {
            var target = new Accumul();
            var result = target.Accum(input);
            Assert.AreEqual(expected, result);
        }

    }
}
