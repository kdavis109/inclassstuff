using strategy.Interfaces;
using strategy.Behaviors;
namespace strategy
{
    public class Pitcher
    {
        public string Name {get; set;}

        public string Team {get; set;}

        public string Throws {get; set;}

        public IPitch pitchBehavior;

         public Pitcher(){
              SetPitchBehavior(new Fastball());
         }
        public void SetPitchBehavior(IPitch pitchBehavior){
            this.pitchBehavior = pitchBehavior;
        }
    }
}