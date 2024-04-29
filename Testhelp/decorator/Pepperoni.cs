namespace decorator
{
    public class Pepperoni : PizzaDecorator
    {
         public Pizza pizza;

        public Pepperoni (Pizza pizza){
            this.pizza = pizza;
        }

        public override string GetDescription(){
              return $"{pizza.GetDescription()}, add Pepperoni";
        }

        public override string GetSize(){
            return $"{pizza.GetSize()}";
        } 

        public override void SetSize(string size){
           pizza.SetSize(size);
        }

         public override double Cost()
        {
            double cost = pizza.Cost();
            switch(pizza.GetSize()){
                case "small":
                cost += 0.50;
                break;
                case "Medium":
                cost += 1.0;
                break;
                case "Large":
                cost += 1.25;
                break;
            }
            return cost;
        }
    }
}