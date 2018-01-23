using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = randomList(20,1,100);
            showValues(test, "Original Random Values:");
            showValues(squaredValues(test), "\nSquared Random Values:");
            showValues(filterOdds(squaredValues(test)), "\nSquared Values, odds filtered out:");

            //***********//
            // Functions //
            //***********//
            
			List<int> randomList(int numOfElem, int lowerBound, int upperBound)
			{
				Random rand = new Random();
				List<int> randi = new List<int>();
				
				for (int i = 0; i < numOfElem; i++)
				{
					randi.Add(rand.Next(lowerBound,upperBound));
				}
				return randi;
			} 

            void showValues(List<int> listVector, string message)
            {
                Console.WriteLine(message);
                foreach (var item in listVector)
                {
                    Console.WriteLine(item);
                }
            }

            List<int> squaredValues(List<int> listVector)
            {
                 List<int> tempList = new List<int>();
                foreach (var item in listVector)
                {
                    tempList.Add((int)Math.Pow((double)item,2));
                }
                Console.WriteLine(tempList[8]);
                return tempList;
            }

            List<int> filterOdds(List<int> listVector)
            {
                List<int> tempList = new List<int>();
                foreach(var item in listVector)
                {
                    if ((item % 2) == 0) 
                    {
                        tempList.Add(item);
                    }
                }
                Console.WriteLine("\nNumber of odds filtered out: " + (listVector.Count - tempList.Count));
                return tempList;
            }
        }
    }
}
