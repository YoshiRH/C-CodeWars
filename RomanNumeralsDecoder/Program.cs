using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1000, 500, 100, 50, 10, 5, 1 };
            List<char> letters = new List<char> { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };

            string roman = "XXI";
            int result = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (roman.Length > i + 1 && letter.IndexOf(roman[i]) > letter.IndexOf(roman[i + 1]))
                {
                    result += (number[letter.IndexOf(roman[i + 1])] - number[letter.IndexOf(roman[i])]);
                    i++;
                }
                else
                {
                    result += number[letter.IndexOf(roman[i])];
                }
            }

            Console.WriteLine(result);
        }
    }
}