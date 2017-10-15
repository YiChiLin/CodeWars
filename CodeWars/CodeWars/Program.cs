using System;
using CodeWars.Utility;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "This is a long long long long long long long long long long long long story.";
            var summary = StringUtility.SummarisingText(text, 10);
            Console.WriteLine(summary);
        }
    }
}
