using strategy.Interfaces;


namespace strategy.Behaviors
{
    public class Fastball : IPitch //implememtation
    {
        public void Pitch()
        {
            System.Console.WriteLine("An 94 mph fastbal was thrown");
        }
    }
}