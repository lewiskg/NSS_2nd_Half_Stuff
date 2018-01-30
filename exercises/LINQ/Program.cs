using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Practice\n");

            // Restriction/Filtering Operations //
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            var results_fruits =    from fruit in fruits
                                    where fruit.StartsWith("L")
                                    select fruit;
            Console.WriteLine("// Restriction/Filtering Operations - Words that start with 'L'://");
            Console.WriteLine("Fruits that start with 'L': {0}", string.Join(",",results_fruits.ToArray()));
            Console.WriteLine("=====================================================\n");


            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var results_numbers = from num in numbers
                                    where num % 6 == 0 ||
                                          num % 4 == 0
                                    select num;

            // var results_numbers = numbers.Where (n => n.numbers % 4 == 0)
            //                             // .Where (n => n.numbers % 6 == 0)
            //                             .Select (n);
            Console.WriteLine("// Restriction/Filtering Operations  - multiples of 4 or 6://");
            Console.WriteLine("Multiples of 4 or 6: {0}", string.Join(",",results_numbers.ToArray()));
            Console.WriteLine("=====================================================\n");
             


            // Ordering Operations //
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre" 
            };

            var results_names = from namee in names 
                                orderby namee descending
                                select namee;
							
            Console.WriteLine("// Ordering Operations  - descending order (Z to A)://");
            Console.WriteLine("Z to A: {0}", string.Join(",",results_names.ToArray()));
            Console.WriteLine("=====================================================\n");



            // Build a collection of these numbers sorted in ascending order
            List<int> Numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var results_Numbers = from n in Numbers 
                                  orderby n ascending
                                  select n;
							
            Console.WriteLine("// Ordering Operations  - ascending://");
            Console.WriteLine("Ascending: {0}", string.Join(",",results_Numbers.ToArray()));
            Console.WriteLine("=====================================================\n");

            // Aggregate Operations //
            // Output how many numbers are in this list
            List<int> NUmbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine("// Aggregate Operations  - count://");
            Console.WriteLine("Number of list elements: {0}", NUmbers.Count);
            Console.WriteLine("=====================================================\n");


            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double sumP = (from p in purchases select p).Sum();
            double sumPp = purchases.Sum();
            Console.WriteLine("// Aggregate Operations  - sum://");
            Console.WriteLine("Sum of list elements: {0:C}", sumP);
            Console.WriteLine("Sum of list elements: {0:C}", sumPp);
            Console.WriteLine("=====================================================\n");



            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            Console.WriteLine("// Aggregate Operations  - max://");
            Console.WriteLine("Max value in list of prices: {0:C}", NUmbers.Max());
            Console.WriteLine("=====================================================\n");

            // Partitioning Operations //
            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            var perfectSquare = from nn in wheresSquaredo
                                where (Math.Truncate(Math.Sqrt(nn)) - Math.Sqrt(nn)) == 0
                                orderby nn ascending
                                select nn;
                                
            // var x = Math.Truncate(Math.Sqrt(floatNumber)) - Math.Sqrt(floatNumber);
		    // Console.WriteLine("truncate: {0}", x == 0.0 ? "true": "false");
            Console.WriteLine("// Partitioning Operations  - find perfect square (root)://");
            Console.WriteLine("Perfect square(s): {0}", string.Join(", ",(perfectSquare.ToArray())));
            Console.WriteLine("=====================================================\n");

        }
    }
}
