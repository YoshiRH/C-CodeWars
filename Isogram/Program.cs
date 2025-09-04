using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string exampleString = "abcdefgh";

            Console.WriteLine(str.ToLower().Distinct().Count() == str.Length);
        }
    }
}