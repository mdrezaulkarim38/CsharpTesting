using System;
namespace CoreLearning;

public class Program
{
    static void Main()
    {
        Calculator calObject = new Calculator();
        int result = calObject.CalculateSum(10, 20);
        Console.WriteLine(result);
    }
}

public class Calculator
{
    public int CalculateSum(int no1, int no2)
    {
        return no1 + no2;
    }
}