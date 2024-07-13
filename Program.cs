using System;
namespace CsharpTesting
{
    class Program
    {
        string color = "Red";

        static void Main(string[] args)
        {
            Program program = new Program();
            program.color = "Blue";
            Console.WriteLine("" + program.color);
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name[0]);

            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) 
            {
                Console.WriteLine(i);
            }
            MyMethod();
        }
        static void MyMethod()
        {
            Console.WriteLine("This is testing");
        }
    }
}