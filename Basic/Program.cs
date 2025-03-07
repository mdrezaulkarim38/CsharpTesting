namespace Basic;
public class Program
{
    public static void Main(string[] args)
    {
        int x, y;
        x = 10;
        y = 20;
        int sum = Add(x, y);
        int total = Add(x, y, sum);
        Console.WriteLine(sum);
        Console.WriteLine(total);
    }

    static int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
    static int Add(int x, int y, int z)
    {
        return x + y + z;
    }
}