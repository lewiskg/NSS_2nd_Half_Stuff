using System;
using System.Collections.Generic;

namespace Family_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Lisa Simpson"},
                {"age", "8"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "Bart Simpson"},
                {"age", "10"}
            });
            myFamily.Add("baby sister", new Dictionary<string, string>(){ 
                {"name", "Maggie Simpson"},
                {"age", "1"}
            });
            myFamily.Add("mother", new Dictionary<string, string>(){ 
                {"name", "Marge Simpson"},
                {"age", "34"}
            });
            myFamily.Add("father", new Dictionary<string, string>(){ 
                {"name", "Homer Simpson"},
                {"age", "36"}
            });

            foreach(var key1 in myFamily.Keys)
            {
                var objs = myFamily[key1];
                
                List<string> objKeys = new List<string>(objs.Keys);
                
                Console.WriteLine("\n{1} is my {0} and is {2} years old.", key1, objs[objKeys[0]], objs[objKeys[1]] );	
            }
            Console.WriteLine("\n");	
        }
    }
}
