namespace compound
{
    public class QuackCounter : IQuack
    {
        IQuack duck;
        static int numOfQuacks;

        public QuackCounter(IQuack duck){
            this.duck = duck;
        }
        public void Quack()
        {
            duck.Quack();
            numOfQuacks++;
        }

        public static int GetNumOfQuacks(){
            return numOfQuacks;
        }
    }
}