using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        [Ignore]
        public void testFun()
        {
            var str = "Apfel";
            var strLength = str.Count();
            var separateArr = str.ToCharArray();
        }
    }

    internal class Accumul
    {
        public string Accum(string str)
        {
            var resultStr = new StringBuilder();
            
            var separateArr = str.ToCharArray();
            for (var i = 0; i < separateArr.Length; i++)
            {
                resultStr.Append(separateArr[i].ToString().ToUpper());
                for (var a = 1; a <= i; a++)
                {
                    resultStr.Append(separateArr[i].ToString().ToLower());
                }
                if (i != separateArr.Length-1)
                {
                    resultStr.Append("-");                    
                }
            }

            return resultStr.ToString();
        }
    }
}
