using System.Diagnostics.Contracts;
using System.IO.Compression;

namespace adapter
{
    public class Spirit : ICharacter
    {
        private string characterName;

        public Spirit(string characterName){
            this.characterName = characterName;
        }
        public void CastSpell(){
            System.Console.WriteLine($"{characterName} casts a spirit spell");
        }

        public void Walk(){
            System.Console.WriteLine($"{characterName} walks forward");
        }
    }
}