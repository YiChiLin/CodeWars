using System.Linq;

namespace CodeWarsTests._6kyu
{
    public class SpinWordsWithMoreThan4Characters
    {
        public string SpinWords(string inputString)
        {
            var separatedWords = inputString.Split(' ').ToList();
            var formatWords = separatedWords.Select(word => word.Length >= 5 ? string.Join("", word.ToCharArray().Reverse()) : word).ToList();
            return string.Join(" ", formatWords);
        }
    }
}