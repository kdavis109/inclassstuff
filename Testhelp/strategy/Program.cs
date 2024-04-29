using strategy;
using strategy.Behaviors;

Pitcher myPitcher = new Pitcher(){Name = "John Smoltz", Team = "Braves", Throws ="Right" };
myPitcher.pitchBehavior.Pitch();

Pitcher tomGlavin = new Starter(){Name = "Tom Glavine", Team = "Braves" };
tomGlavin.pitchBehavior.Pitch();

tomGlavin.SetPitchBehavior(new Fastball());
tomGlavin.pitchBehavior.Pitch();

tomGlavin.SetPitchBehavior(new Changeup());
tomGlavin.pitchBehavior.Pitch();

