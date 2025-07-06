using System;
namespace BasicLearn;

public class Program
{
    static void Main(string[] args)
    {
        int number1 = 10, number2 = 20;
        Console.WriteLine(number1 + " before " + number2);
        int temp = number1;
        number1 = number2;
        number2 = temp;
        Console.WriteLine(number1 + " after " + number2);
    }
}