using System.Text;

namespace CodeWars._7kyu
{
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