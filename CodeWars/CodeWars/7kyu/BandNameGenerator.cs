using System.Linq;

namespace CodeWars._7kyu
{
    public class BandNameGenerator
    {
        public string GetBandName(string originalName)
        {
            var startLetter = originalName.First().ToString().ToUpper();
            var endLetter = originalName.Last().ToString().ToUpper();

            var endSection = originalName.Substring(1);
            if (!startLetter.Equals(endLetter)) return "The " + startLetter + endSection;

            endSection = string.Concat(Enumerable.Repeat(endSection, 2));
            return startLetter + endSection;
        }
    }
}