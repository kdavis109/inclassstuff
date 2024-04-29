

namespace decorator
{
    public class StuffedCrust : Pizza
    {
         public StuffedCrust(){
            description = "Stuffed Crust";
        }
        public override double Cost()
        {
            double cost = 0.0;
            switch(size){
                case "small":
                cost += 8.50;
                break;
                case "Medium":
                cost += 10.25;
                break;
                case "Large":
                cost += 12.0;
                break;
            }
            return cost;
        }
    }
}