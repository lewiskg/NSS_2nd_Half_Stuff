using System;
using System.Collections.Generic;

namespace Stock_Purchase_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Stocks myStocks = new Stocks();
            myStocks.totalPortfolio();
            myStocks.printPortfolio();
        }

        class Stocks
        {
            Dictionary<string, double> totalPurchaseInfo = new Dictionary<string, double>();

            Dictionary<string, string> stocks = new Dictionary<string, string>()
            {
                {"GM", "General Motors"},
                {"GE", "General Electric"},
                {"CAT", "Caterpillar"},
                {"BA", "Boeing"},
                {"LMT", "Lockheed Martin"},
                {"GD", "General Dynamics"},
                {"YHOO", "Yahoo"},
                {"GOOG", "Google"},
                {"APPL", "Apple"}
            };

            List<Tuple<string, int, double>> purchases = new List<Tuple<string, int, double>>()
            {
                Tuple.Create("GM", 150, 23.21),
                Tuple.Create("GE", 32, 17.87),
                Tuple.Create("GE", 80, 19.02),
                Tuple.Create("CAT", 150, 243.21),
                Tuple.Create("YHOO", 32, 29.25),
                Tuple.Create("APPL", 80, 875.22),
                Tuple.Create("GD", 150, 128.21),
                Tuple.Create("GD", 92, 170.51),
                Tuple.Create("BA", 50, 156.78),
                Tuple.Create("LMT", 150, 23.99),
                Tuple.Create("GOOG", 132, 475.87),
                Tuple.Create("GOOG", 180, 562.02)
            };

            public void totalPortfolio()
            {
                foreach (Tuple<string, int, double> purchase in purchases)
                {
                    string companyName = stocks[purchase.Item1];

                    if (totalPurchaseInfo.ContainsKey(companyName) == false)
                    {
                        totalPurchaseInfo.Add(companyName, (double) purchase.Item2 * purchase.Item3);

                    } else if (totalPurchaseInfo.ContainsKey(companyName) == true)
                    {
                        totalPurchaseInfo[companyName] += (double) purchase.Item2 * purchase.Item3;
                    }
                }
            }

            public void printPortfolio()
            {
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("     Company      |  Valuation  ");
                Console.WriteLine("--------------------------------");
                foreach (var i in totalPurchaseInfo)
                {
                    // Console.WriteLine("{0} \t {1:C}", i.Key, i.Value);
                    Console.WriteLine(String.Format("{0,-17} | {1,12:C}", i.Key, i.Value));
                }
                Console.WriteLine("--------------------------------\n");
            }
        }
    }
}
