using System;
using System.Linq;

public static class Kata
{
    public static string Order(string words)
    {
        string result = string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));

        return result;

    }
}