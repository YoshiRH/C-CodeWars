using System.Linq;

public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        string number = "(" + string.Concat(numbers.Take(3)) + ") ";
        number += string.Concat(numbers.Skip(3).Take(3)) + "-";
        number += string.Concat(numbers.Skip(6).Take(4));

        return number;
    }
}