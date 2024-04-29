namespace compound
{
    public class GooseAdapter : IQuack
    {
        Goose goose;

        public GooseAdapter(Goose goose){
            this.goose = goose;
        }
        
        public void Quack(){
            goose.Honk();
        }
    }
}