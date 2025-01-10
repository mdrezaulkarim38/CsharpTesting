using System;
namespace Basic;
public class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        Console.WriteLine("Hello World!");
    }

    public class Employee
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }

        public void Validate()
        {
            if (Name is null)
            {
                Console.WriteLine("Name is required");
            }
        }
    }
}