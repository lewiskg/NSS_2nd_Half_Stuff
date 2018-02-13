using System;
using System.Text;
using System.Collections.Generic;

namespace RomanNumerals
{
    class Roman
    {
        public static string NumToRoman(string snumber)
        {
            int[] numArray = BreakUpNum(snumber);
            Array.Reverse(numArray);
            int numLength = snumber.ToString().Length;
            
            string[] romanNumsOnes = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            string[] romanNumsTens = {"X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
            string[] romanNumsHundreds = {"C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
            string[] romanNumsThousands = {"M", "MM", "MMM", "M(V)", "(V)", "(V)M", "(V)MM", "(V)MMM", "M(X)"};
            string[] romanNumsTenThousands = {"(X)", "(X)(X)", "(X)(X)(X)", "(X)(L)", "(L)", "(L)(X)", "(L)(X)(X)", "(L)(X)(X)(X)", "(X)(C)"};
            string[] romanNumsHundredThousands = {"(C)", "(C)(C)", "(C)(C)(C)", "(C)(D)", "(D)", "(D)(C)", "(D)(C)(C)", "(D)(C)(C)(C)", "(C)(M)"};

            List<string> romanNumeral = new List<string>();
            int value;
            int index = numLength;
            
            while (index > 0)
            {
                value = numArray[index  - 1];
                switch (index)
                {
                    case 1:  // ones place
                        if (value > 0)
                        {
                            romanNumeral.Add(romanNumsOnes[value - 1]);
                        }
                        break;
                    case 2:  // tens place
                        if (value > 0)
                        {
                            romanNumeral.Add(romanNumsTens[value - 1]);
                        }
                        break;
                    case 3:  // hundreds place
                        if (value > 0)
                        {
                            romanNumeral.Add(romanNumsHundreds[value - 1]);
                        }
                        break;
                    case 4:  // thousands place
                        if (value > 0)
                        {
                            romanNumeral.Add(romanNumsThousands[value - 1]);
                        }
                        break;
                    case 5:  // ten-thousands place
                        if (value > 0)
                        {
                            romanNumeral.Add(romanNumsTenThousands[value - 1]);
                        }
                        break;
                    case 6:  // hundred-thousands place
                        if (value > 0)
                        {
                            romanNumeral.Add(romanNumsHundredThousands[value - 1]);
                        }
                        break;
                    default:
                        return "Number entered is > 1E6.";
                }
                index--;
            }

            string[] temp = romanNumeral.ToArray();
            string temp2 = ConvertStringArrayToString(temp);
            return temp2;
        }

        public static int[] BreakUpNum(string snumber)
        {
            char[] charNumArray = snumber.ToCharArray();
            int charArrLength = charNumArray.Length;
            int[] numArray = new int[charArrLength];

            for (int i = 0; i < charArrLength; i++)
            {
                numArray[i] = Convert.ToInt32(Convert.ToString(charNumArray[i]));
            }
            return numArray;
        }

        public static string ConvertStringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
            }
            return builder.ToString();
        }
    }
}