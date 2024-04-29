using strategy.Interfaces;

namespace strategy.Behaviors
{
    public class Curveball : IPitch // implementation
    {
        public void Pitch()
        {
            System.Console.WriteLine("An 80 mph curveball was thrown");
        }
    }
}