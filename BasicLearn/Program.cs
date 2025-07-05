using System;
namespace BasicLearn;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter userName");
        string userName = Console.ReadLine();
        Console.WriteLine("User Name is: " + userName);
        Car Ford = new();
        Console.WriteLine($"Car {Ford.model}");
    }
}

public class Car
{
    public string model;
    public Car()
    {
        model = "Mustang";
    }
}