using adapter;

ICharacter myChar = new Spirit("Anne");
MysticVehicle myVehicle = new MysticVehicle();
ICharacter yourVehicle = new CharacterAdapter(new MysticVehicle());

myChar.CastSpell();
myChar.Walk();

myVehicle.FireWeapon();
myVehicle.DriveForward();

yourVehicle.CastSpell();
yourVehicle.Walk();