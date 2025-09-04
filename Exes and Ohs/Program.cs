using System.Linq;
using System;

public static class Kata
{
    public static bool XO(string input)
    {
        int x = 0, o = 0;

        input = input.ToLower();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'x') x++;
            if (input[i] == 'o') o++;
        }


        return x == o ? true : false;
    }
}