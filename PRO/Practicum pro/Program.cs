using System;

namespace Practicum_pro
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Character myBaseCharacter = new Character();
           
           Mushroom myMushroom = new Mushroom();
           myMushroom.Growth();
            Console.WriteLine(myMushroom.point+" "+ myMushroom.points+ " " + myMushroom.point1);


            GoldenMushroom myGoldenMushroom = new GoldenMushroom();
            myGoldenMushroom.Speed();
            Console.WriteLine(myGoldenMushroom.speed1+" "+ myGoldenMushroom.speed+ " " + myGoldenMushroom.speed2);

            Star myStar = new Star();
            myStar.Invincible();
            Console.WriteLine(myStar.Ultraspeed1+" "+ myStar.Ultraspeed+ " " + myStar.Ultraspeed2);
        }
    }
}
