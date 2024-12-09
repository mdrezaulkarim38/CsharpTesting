namespace MyApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two Numbers: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int result = number1 + number2;
        Console.WriteLine($"The Sum is: {result}");
    }
}