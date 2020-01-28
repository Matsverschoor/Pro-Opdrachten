using System;

namespace Theorie_classes
{
    public class Player
    {
        public int health = 10;
        public int experience = 0;
        private string name = "BakSteen";

        public Player(string newName = "BakSteen"){
            ChangeName(newName);
        }

        public void statistieken(int health, int experience){
            Console.WriteLine("Hier begint je HP en Experience: " + health + ", " + experience);
            Console.WriteLine("Je begint met 1 HP en 1 Experience");
            health++;
            experience++;
            Console.WriteLine("HP: " + health + " Experience: " + experience);
        }
        public void Jump(){
            Console.WriteLine("Jumping");
        }

        public string getName(){
            return name;
        }
         public string[] Shoot(int amount){

            string[] result = new string[amount];

            for(int i = 0; i < amount; i++){
                result[i] = (name + ": SHOOT: " + i);
            }
            return result;
         }

         private void ChangeName (string newName){
             Console.WriteLine("OLD NAME: " + name);
             Console.WriteLine("NEW NAME: " + newName);
             name = newName;
         }

    }
}