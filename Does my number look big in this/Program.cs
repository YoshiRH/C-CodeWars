using System.Linq;
using System;

public class Kata
{
    public static bool Narcissistic(int value)
    {
        var digits = value.ToString().ToArray();
        int size = digits.Length;

        double sum = 0;

        foreach (char x in digits)
        {
            sum += Math.Pow((x - '0'), size);
        }

        return (value == sum);
    }
}