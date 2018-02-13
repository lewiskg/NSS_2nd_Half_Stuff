using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            string RomanLetters = "I V X L C D M";
            Console.WriteLine("**** Arabic Number to Roman Numeral or Roman Numeral to Arabic Number Convertion Program ****");
            Console.WriteLine("--- Enter '0' to end program.\n");

            int status = 1;
            while(status > 0)
            {
                Console.WriteLine("Enter a positive integer number '=' to or '<' 1E6: ");
                string snum = Console.ReadLine();

                try
                {
                    if (Char.IsLetter(snum, 0) && RomanLetters.Contains(Convert.ToString(snum[0])))
                    {
                        string arabicNum = Arabic.RomanToArabic(snum);
                        Console.WriteLine($"{snum} = {arabicNum}");
                    }
                    else //if (Convert.ToInt32(snum) > 0)
                    {
                        string romanNum = Roman.NumToRoman(snum);
                        Console.WriteLine($"{snum} = {romanNum}");
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
