using System.Linq;

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        var numbers = arr.Where(x => x != 0).ToArray();
        var zeros = arr.Where(x => x == 0).ToArray();
        var result = numbers.Concat(zeros).ToArray();

        return result;
    }
}