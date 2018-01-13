using System;
using System.Collections.Generic;

namespace CodeWarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<int, int> {
                { 1,1}, { 2,-1}, { 3,1}, { 4,-1},
                { 5,1}, { 6,-1}, { 7,1}, { 8,1},
                { 9,1}
            };

            var winningOrderCount = 0;
            var set = 0;
            foreach (var item in data)
            {
                if (item.Value > 0)
                {
                    winningOrderCount++;
                    if (winningOrderCount == 3)
                    {
                        set++;
                        winningOrderCount = 0;
                    }
                }
                else
                {
                    winningOrderCount = 0;
                }
            }

            Console.WriteLine($"Set = {set}");
            Console.ReadLine();
        }
    }
}
