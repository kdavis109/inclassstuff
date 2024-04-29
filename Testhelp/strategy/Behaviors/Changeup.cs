using strategy.Interfaces;

namespace strategy.Behaviors
{
    public class Changeup : IPitch //implementation
    {
      public void Pitch()
      {
        System.Console.WriteLine("A 78 mph changeup has been thrown");
      }  
    }
}