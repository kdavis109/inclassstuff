namespace compound
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuack CreateDuckCall(){
            return new QuackCounter(new DuckCall());
        }
        public override IQuack CreateMallardDuck(){
            return new QuackCounter(new MallardDuck());
        }
        public override IQuack CreateRedheadDuck(){
            return new QuackCounter(new RedheadDuck());
        }
        public override IQuack CreateRubberDuck(){
            return new QuackCounter(new RubberDuck());
        }
        

    }
}