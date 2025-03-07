namespace Basic;
public class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        Console.WriteLine($"The factorial of {x} is {factorial(x)}");
    }

    static int factorial(int number)
    {
        if(number == 1)
        {
            return (1);
        }
        else
        {
            return (number * factorial(number - 1));
        }
    }
}
