namespace Basic;
public class Program
{
    public static void Main(string[] args)
    {
        int x, y;
        x = 10;
        y = 20;
        int sum = Add(x, y);
        Console.WriteLine(sum);
    }

    static int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
}