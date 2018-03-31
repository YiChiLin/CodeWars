namespace CodeWarsTests._5kyu
{
    public class Runner
    {
        public int Position { get; set; }
        public decimal Speed { get; set; }

        public decimal GetCurrentPosition(int timeOfSecond)
        {
            return Position == 1000 ? Position : Position + GetSpeedPerSecond() * timeOfSecond;
        }

        private decimal GetSpeedPerSecond()
        {
            return Speed / 60;
        }
    }
}