using System.Linq;

public class Kata
{
    public static string ReverseWords(string str)
    {
        var words = str.Split(' ').Reverse();
        return string.Join(' ', words);
    }
}