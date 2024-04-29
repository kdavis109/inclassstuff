using decorator;

//Pizza chiTown = new ChicagoStyle();
//chiTown.SetSize("Large");
//chiTown = new Cheese(chiTown);
//chiTown = new Cheese(chiTown);
//chiTown = new Sausage(chiTown);
//System.Console.WriteLine($"{chiTown.GetDescription()} costs ${chiTown.Cost()}");

Pizza stuffedCrust = new Cheese(new Cheese(new Sausage(new StuffedCrust())));
stuffedCrust.SetSize("Medium");
System.Console.WriteLine($"{stuffedCrust.GetDescription()} costs ${stuffedCrust.Cost()}");