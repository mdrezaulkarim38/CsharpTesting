namespace CoreLearning;

public class Program
{
    public static void Main(string[] args)
    {
        int Number1, Number2, Result;
        try
        {
            Console.WriteLine("Enter First Number:");
            Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            Number2 = int.Parse(Console.ReadLine());
            Result = Number1 / Number2;
            Console.WriteLine($"Result = {Result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Some Error Occurred..."+ ex.Message);
        }
        Console.ReadKey();
    }
}

