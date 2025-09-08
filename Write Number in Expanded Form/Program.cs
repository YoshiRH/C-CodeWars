using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static string ExpandedForm(long num)
    {
        long multiply = 1;
        var digits = num.ToString().Reverse().ToArray();
        var parts = new List<string>();

        foreach (char x in digits)
        {
            int digit = x - '0';
            long val = digit * multiply;
            if (val > 0)
            {
                parts.Add(val.ToString());
            }
            multiply *= 10;
        }

        parts.Reverse();
        return string.Join(" + ", parts);

    }
}