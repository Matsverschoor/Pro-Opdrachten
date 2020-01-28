using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Hoi wil je plus, keer, delen of modulo? ");
            string antwoord = Console.ReadLine();

            if(antwoord == "plus"){
            
               Console.WriteLine("Kies je 1e getal: ");
               string getal1 = Console.ReadLine();
               
               Console.WriteLine("Kies je 2e getal: ");
               string getal2 = Console.ReadLine();
                
               int res = Convert.ToInt32(getal1);
               int res2 = Convert.ToInt32(getal2);

               Plus(res, res2);            
            }
            if(antwoord == "keer"){
            
               Console.WriteLine("Kies je 1e getal: ");
               string getal1 = Console.ReadLine();
               
               Console.WriteLine("Kies je 2e getal: ");
               string getal2 = Console.ReadLine();
                
               int res = Convert.ToInt32(getal1);
               int res2 = Convert.ToInt32(getal2);

               Keer(res, res2);            
            }
            if(antwoord == "delen"){
            
               Console.WriteLine("Kies je 1e getal: ");
               string getal1 = Console.ReadLine();
               
               Console.WriteLine("Kies je 2e getal: ");
               string getal2 = Console.ReadLine();
                
               int res = Convert.ToInt32(getal1);
               int res2 = Convert.ToInt32(getal2);

               Delen(res, res2);            
            }

            if(antwoord == "modulo"){
            
               Console.WriteLine("Kies je 1e getal: ");
               string getal1 = Console.ReadLine();
               
               Console.WriteLine("Kies je 2e getal: ");
               string getal2 = Console.ReadLine();
                
               int res = Convert.ToInt32(getal1);
               int res2 = Convert.ToInt32(getal2);

               Modulo(res, res2);            
            }
        }
        static int Plus(int getal1, int getal2){
           int resultaat = getal1 + getal2;
            
           Console.WriteLine("Dit is het antwoord: " + resultaat);
           return resultaat;
        }
        static int Keer(int getal1, int getal2){
           int resultaat = getal1 * getal2;
            
           Console.WriteLine("Dit is het antwoord: " + resultaat);
           return resultaat;
        }
        static int Delen(int getal1, int getal2){
           int resultaat = getal1 / getal2;
            
           Console.WriteLine("Dit is het antwoord: " + resultaat);
           return resultaat;
        }
        static int Modulo(int getal1, int getal2){
           int resultaat = getal1 % getal2;
            
           Console.WriteLine("Dit is het antwoord: " + resultaat);
           return resultaat;
        }
    }
}
