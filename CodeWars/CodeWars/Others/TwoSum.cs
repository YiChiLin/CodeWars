namespace CodeWars.Others
{
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
                        return new[] { i, i + 1 };
                }
            }
            return new[] {0, 0};
        }
    }
}