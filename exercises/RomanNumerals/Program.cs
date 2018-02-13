using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Number to Roman Numeral Convertion Program ****");
            Console.WriteLine("--- Enter '0' to end program.\n");

            int status = 1;
            while(status > 0)
            {
                Console.WriteLine("Enter a positive integer number '=' to or '<' 1E6: ");
                string snum = Console.ReadLine();

                try
                {
                    if (Convert.ToInt32(snum) > 0)
                    {
                        string romanNum = Roman.NumToRoman(snum);
                        Console.WriteLine($"{snum} = {romanNum}");
                    } 
                    else 
                    {
                        status = 0;
                        Console.WriteLine("Exiting Program.\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nAn error occurred: '{0}'| Entered: '{1}'", e.Message, snum);
                    Console.WriteLine("Exiting Program.\n");
                    status = 0;
                }
            }
        }
    }
}
