namespace compound
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuack CreateDuckCall();
        public abstract IQuack CreateMallardDuck();
        public abstract IQuack CreateRedheadDuck();
        public abstract IQuack CreateRubberDuck();
    }
}