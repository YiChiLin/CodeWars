using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyu
{
    public class DeadAnt
    {
        private readonly string _aliveAnt = "ant";
        public int Count(string ants)
        {
            if (string.IsNullOrEmpty(ants))
                return 0;
            var deadAnts = ants.Replace(_aliveAnt,"");

            var deadAntBodyCaculate = new List<int>
            {
                deadAnts.Count(x => x == 'a'),
                deadAnts.Count(x => x == 'n'),
                deadAnts.Count(x => x == 't')
            };

            return deadAntBodyCaculate.Max();
        }
    }
}