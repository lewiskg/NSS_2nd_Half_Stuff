using System;
using System.Collections.Generic;

namespace Stock_Purchase_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("GE", "General Electric");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("BA", "Boeing");
            stocks.Add("LMT", "Lockheed Martin");
            stocks.Add("GD", "General Dynamics");
            stocks.Add("YHOO", "Yahoo");
            stocks.Add("GOOG", "Google");
            stocks.Add("APPL", "Apple");


            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 150, price: 243.21));
            purchases.Add((ticker: "YHOO", shares: 32, price: 29.25));
            purchases.Add((ticker: "APPL", shares: 80, price: 875.22));
            purchases.Add((ticker: "GD", shares: 150, price: 128.21));
            purchases.Add((ticker: "GD", shares: 92, price: 170.51));
            purchases.Add((ticker: "BA", shares: 50, price: 156.78));
            purchases.Add((ticker: "LMT", shares: 150, price: 23.99));
            purchases.Add((ticker: "GOOG", shares: 132, price: 475.87));
            purchases.Add((ticker: "GOOG", shares: 180, price: 562.02));
 

            Dictionary<string, double> totalPurchaseInfo = new Dictionary<string, double>();
         
            foreach ((string ticker, int shares, double price) purchase in purchases)
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
