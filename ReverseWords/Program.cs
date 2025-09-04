using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string exampleString = "Lorem ipsum Lorem ipsum";

            Console.WriteLine(string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray()))));
            Console.ReadKey();
        }
    }
}