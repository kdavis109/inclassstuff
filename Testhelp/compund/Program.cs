using compound;
Simulate();

static void Simulate(){
    CountingDuckFactory factory = new CountingDuckFactory();
    IQuack mallardDuck = factory.CreateMallardDuck();
    IQuack duckCall = factory.CreateDuckCall();
    IQuack redHeadDuck = factory.CreateRedheadDuck();
    IQuack rubberDuck = factory.CreateRubberDuck();
    
    IQuack goose = new GooseAdapter(new Goose());

    System.Console.WriteLine("Time to quack");
    RunQuack(mallardDuck);
    RunQuack(duckCall);
    RunQuack(redHeadDuck);
    RunQuack(rubberDuck);
    RunQuack(goose);
    System.Console.WriteLine("Number of total quacks is: "+ QuackCounter.GetNumOfQuacks());
}

static void RunQuack(IQuack duck){
    duck.Quack();
}