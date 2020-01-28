using System;

namespace Theorie_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player myPlayerInstance = new Player();
            Player secondPlayer = new Player("");
            Player thirdPlayer = new Player("");
            Player fourthplayer = new Player("");

            myPlayerInstance.health = 20;
            myPlayerInstance.experience = 5;
            myPlayerInstance.Shoot(3);
            myPlayerInstance.Jump();

            Console.WriteLine("Names: " + myPlayerInstance.getName() + ", " + secondPlayer.getName() + ", " + thirdPlayer.getName() + ", " + fourthplayer.getName());

        }


    }
}
