using System.Collections.Generic;

namespace CodeWars.Utility
{
    public class StringUtility
    {
        public static string SummarisingText(string text,int maxLength = 20)
        {

            if (text.Length < maxLength)
                return text;

            var totalCharacters = 0;
            var words = text.Split(' ');
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            return string.Join(" ", summaryWords) + " ...";
        }

    }
}
