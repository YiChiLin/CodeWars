namespace CodeWars
{
    public interface ILife
    {
        void Eat();
    }

    public abstract class DailyLife : ILife
    {
        public abstract void Breakfast();
        public abstract void Lunch();
        public abstract void Dinner();

        public abstract int Number { get; set; }

        public void Eat()
        {
            Breakfast();
            Lunch();
            Dinner();
        }
    }

    public class JeanLife : DailyLife
    {
        public override int Number { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public override void Breakfast()
        {
            throw new System.NotImplementedException();
        }

        public override void Dinner()
        {
            throw new System.NotImplementedException();
        }

        public override void Lunch()
        {
            throw new System.NotImplementedException();
        }

        public void StartNewDay()
        {
            Eat();
        }
    }

    class Practice
    {
    }
}
