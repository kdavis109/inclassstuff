using strategy.Behaviors;

namespace strategy
{
    public class Starter : Pitcher //inherit, is-a
    {
        public Starter(){
             Throws = "Left";
             SetPitchBehavior( new Curveball());
        }
      
    }
}