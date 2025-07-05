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

public class Patient
{
    public string Name { get; set; }
    public string Address { get; set; }
    public Doctor Doctor{ get; set; }
}

public class Doctor
{
    public string Name { get; set;}
}