using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Number to Roman Numeral Convertion Program ****");
            Console.WriteLine("Enter a positive integer number '=' to or '<' 1E6: ");
            string snum = Console.ReadLine();

            string romanNum = Roman.NumToRoman(snum);

            Console.WriteLine($"{snum} = {romanNum}");
        }
    }
}
