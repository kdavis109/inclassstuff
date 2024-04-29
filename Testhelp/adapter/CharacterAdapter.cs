namespace adapter
{
    public class CharacterAdapter : ICharacter
    {
        MysticVehicle vehicle;
        public CharacterAdapter(MysticVehicle vehicle){
            this.vehicle = vehicle;
        }
        public void CastSpell()
        {
            vehicle.FireWeapon();
        }

        public void Walk()
        {
            vehicle.DriveForward();
        }
    }
}