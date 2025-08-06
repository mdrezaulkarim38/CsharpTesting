namespace CoreLearning;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter Started");
        Console.WriteLine("Choose 1. Fahrenheit to Celsius");
        Console.WriteLine("Choose 2. Celsius to Fahrenheit");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine());
                Console.WriteLine("Fahrenheit: " + ((fahrenheit - 32) / 1.8) );
                break;
            case 2:
                Console.WriteLine("Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                Console.WriteLine("Celsius: " + ((celsius*1.8)+32));
                break;
            default:
                Console.WriteLine("Please enter a valid option");
                break;
        }
    }
}