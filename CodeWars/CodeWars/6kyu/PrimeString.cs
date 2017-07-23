namespace CodeWars._6kyu
{
    internal class PrimeString
    {
        public bool IsPrimeString(string str)
        {
            if (str.Length < 1)
                return false;

            for (var index = 1; index <= str.Length/2; index++)
            {
                var mappedStr = str.Substring(0, index);
                var filterStr = str.Replace(mappedStr, "");
                if (filterStr.Length == 0)
                    return false;
            }
            return true;
        }
    }
}