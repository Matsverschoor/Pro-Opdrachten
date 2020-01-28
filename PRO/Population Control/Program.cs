using System;
using System.Collections;
using System.Collections.Generic;

namespace Les3PopulationControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maak een ArrayList aan om personen in op te slaan
            //ArrayList people = new ArrayList();
            //Maak een nieuwe persoon aan
               Person newPerson = new Person();
               Person newPerson2 = new Person();
               Person newPerson3 = new Person();
               Person newPerson4 = new Person();
               Person newPerson5 = new Person();
            
            List<Person> people = new List<Person>();

            people.Add(newPerson);
            people.Add(newPerson2);
            people.Add(newPerson3);     
            people.Add(newPerson4);
            people.Add(newPerson5);
           
            
                for(int i = 0; i < people.Count; i++){
                //Vraag om de naam van de persoon
                Console.WriteLine("goedemorgen wat is je naam?");
                people[i].SetName(Console.ReadLine());

                Console.WriteLine("Wat voor kleur zijn je ogen");
                people[i].SetOgen(Console.ReadLine());

                Console.WriteLine("Wat is je lengte");
                people[i].SetLengte(Console.ReadLine());

                Console.WriteLine("Wat is je leeftijd");
                people[i].Setleeftijd(Console.ReadLine());

                Console.WriteLine("Wat is je geboorteland");
                people[i].SetGeboorteland(Console.ReadLine());

                Console.WriteLine("Wat is je BSN nummer");
                people[i].SetBSN(Console.ReadLine());
                Console.Clear();

             
            }
        }
    }
}