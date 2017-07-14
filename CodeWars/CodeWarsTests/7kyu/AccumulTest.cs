using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class AccumulTest
    {
        [Test]
        public void Accumlate_A_and_Will_Get_A()
        {
            var target = new Accumul();
            var result = target.Accum("A");
            
        }
    }

    internal class Accumul
    {
        public string Accum(string str)
        {
            throw new System.NotImplementedException();
        }
    }
}
