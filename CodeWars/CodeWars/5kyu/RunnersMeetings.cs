using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests._5kyu
{
    public class RunnersMeetings
    {
        public int GetMeetingCardinality(int[] startPosition, int[] speedsPerMinute)
        {
            var positionsBySecond = new Dictionary<int, List<int>>();
            var meetingCardinality = new List<int>();
            var runners = startPosition.Select((t, i) => new Runner { Position = t, Speed = speedsPerMinute[i] }).ToList();

            var time = 1;
            while (runners.FindAll(runner => runner.GetCurrentPosition(time) >= 1000).Count != runners.Count)
            {
                positionsBySecond.Add(time, new List<int>());
                foreach (var runner in runners)
                {
                    var currentPosition = Convert.ToInt32(runner.GetCurrentPosition(time));
                    positionsBySecond[time].Add(currentPosition);
                }

                var groupingPositions = positionsBySecond[time].GroupBy(item => item);
                if (groupingPositions.Count() != runners.Count)
                {
                    meetingCardinality.Add(groupingPositions.Max(item => item.Count()));
                }

                time++;
            }

            return meetingCardinality.Count == 0 ? -1 : meetingCardinality.Max();
        }
    }
}