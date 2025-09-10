using CoreLearning.LogicalProgram.Fibonacci;

namespace CoreLearning;

public class Program
{
    static void Main()
    {
        int number = 10;
        FibonacciCode fc = new FibonacciCode();
        fc.FibonacciSeries(0, 1, 1, number);
        Console.WriteLine("\n"+ fc.NthFibonacciNumber(number - 1));
    }
}