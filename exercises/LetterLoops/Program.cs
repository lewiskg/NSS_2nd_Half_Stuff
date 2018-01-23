using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string of characters: ");
            string input = Console.ReadLine().ToLower();
            string INPUT = input.ToUpper();

            string output = "";
            int inputLength = input.Length;

            for (int i = 0; i < inputLength; i++)
            {
                int j = i;
                output += INPUT[i];
                while (j > 0)
                {
                    output += input[i];
                    j--;
                }
                if (i < (inputLength - 1))
                {
                    output += "-";
                }
            }
            Console.WriteLine(output);
        }
    }
}
