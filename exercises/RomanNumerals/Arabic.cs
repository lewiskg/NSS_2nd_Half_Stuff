using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    class Arabic
    {
        public static string RomanToArabic(string snumber)
        {
            char[] romanNumber = snumber.ToCharArray();
            Dictionary<string, int> romanDictionary = new Dictionary<string, int>
            {
                {"I",1},
                {"V",5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000}
            };

            List<int> numList = new List<int>();

            foreach (var n in romanNumber)
            {
                numList.Add(romanDictionary[Convert.ToString(n)]);
            }

            // foreach (var i in numList)
            // {
            //     Console.WriteLine("{0}", i);
            // }

            List<int> numList2 = new List<int>();

            for (int j = 0; j < snumber.Length; j++)
            {
                if (j != (snumber.Length - 1))
                {
                    if (numList[j] < numList[j + 1])
                    {
                        numList2.Add(numList[j] * -1);
                    }
                    else
                    {
                        numList2.Add(numList[j]);
                    }
                }
                else if (j == (snumber.Length - 1))
                {
                    numList2.Add(numList[j]);
                }
            }

            // foreach (var i in numList2)
            // {
            //     Console.WriteLine("{0}", i);
            // }
            return Convert.ToString(numList2.Sum());
        }

    }

}