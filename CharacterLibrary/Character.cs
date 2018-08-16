using System;
namespace CharacterLibrary
{
    public class Character
    {
        public string CharacterName {get; set;}
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set;  }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; }

        private string[] RandomNames;

        public Character()
        {
            CharacterName = string.Empty;
            Strength = 0;
            Intelligence = 0;
            Wisdom = 0;
            Dexterity = 0;
            Constitution = 0;
            Charisma = 0;
            HitPoints = 0;
            ExperiencePoints = 0;

            RandomNames = new string[5] {"Frodo", "Bilbo", "Dori", "Nori", "Gandalf"};
        }

        public void GenerateCharacter(){

            CharacterName = getRandomName();
            Strength = RollAttributeScore();
            Intelligence = RollAttributeScore();
            Wisdom = RollAttributeScore();
            Dexterity = RollAttributeScore();
            Constitution = RollAttributeScore();
            Charisma = RollAttributeScore();

            PrintCharacter();
        }

        private string getRandomName(){
            var rnd = new Random();
            var randomIndex = rnd.Next(0, RandomNames.Length);
            return RandomNames[randomIndex];
        }

        private int RollAttributeScore(){
            //roll three six sided dice to get the score
            Random rnd = new Random();
            int score = rnd.Next(3, 18); // creates a number between 3 and 18
            return score;
        }

        private void PrintCharacter(){
            Console.WriteLine("Character Name: " + this.CharacterName);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Intelligence" + Intelligence);
            Console.WriteLine("Wisdom: " + Wisdom);
            Console.WriteLine("Dexterity: " + Dexterity);
            Console.WriteLine("Constitution: " + Constitution);
            Console.WriteLine("Charisma: " + Charisma);
        }

    }
}
