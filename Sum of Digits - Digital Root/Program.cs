public class Number
{
    public static int DigitalRoot(long n)
    {
        if (n == 0)
            return 0;
        if (n % 9 == 0)
            return 9;

        string number = n.ToString();
        int sum = 0;

        foreach (char c in number)
        {
            int x = c - '0';
            sum += x;
            sum = sum % 9;
        }

        return sum;
    }
}