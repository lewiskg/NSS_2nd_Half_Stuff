using System;
using System.Collections.Generic;

namespace Car_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[] { "AMC Gremlin", "Ford Pinto", "AMC Pacer", "Renault Le Car" };

            Console.WriteLine("\nList of Showroom Cars");
            foreach (string n in cars)
            {
                Console.WriteLine(String.Format("|{0,20}|",n));
            }

            HashSet<string> Showroom = new HashSet<string>(cars);
            Showroom.Add("Ford Pinto");

            Console.WriteLine("\nList of Showroom Cars (again)");
            printHash(Showroom);


            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Mosler Consulier GTP");
            UsedLot.Add("Camaro Iron Duke");

            Showroom.UnionWith(UsedLot);

            Console.WriteLine("\nList of Showroom cars unioned with UsedLot");
            printHash(Showroom);


            Showroom.Remove("Ford Pinto");
            Console.WriteLine("\nRemoved the 'Ford Pinto' from the Showroom cars list ");
            printHash(Showroom);

            string[] junkYardCars = new string[] { "AMC Gremlin", "Ford Pinto", "AMC Pacer", "Renault Le Car", "Lamborghini LM002", "Plymouth Prowler","Ford Excursion" };
            
            HashSet<string> JunkYard = new HashSet<string>(junkYardCars);
            JunkYard.ExceptWith(Showroom);

            Console.WriteLine("\nRelative complement of JunkYard and Showroom cars");
            printHash(JunkYard);

            Showroom.UnionWith(JunkYard);            
            Console.WriteLine("\nUnion of JunkYard and Showroom cars");
            printHash(JunkYard);


            void printHash(HashSet<string> arrayToPrint)
            {
                foreach (var n in arrayToPrint)
                {
                    Console.WriteLine(String.Format("|{0,20}|",n));
                }
            }
        }
    }
}
