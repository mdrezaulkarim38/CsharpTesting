namespace MyApp;
class Program
{
    static void Main(string[] args)
    {
        int x = 20, y = 10;
        int result = Sum(x, y);
        Console.WriteLine($"Sum is {result}");
    }
    static int Sum(int x, int y)
    {
        int sum = x + y;
        return sum;
    }
}