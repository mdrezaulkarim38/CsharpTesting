namespace CoreLearning;

public static class Program
{
    public static void Main(string[] args)
    {
        int digit;
        Console.Write("Enter a number: ");
        digit = Convert.ToInt32(Console.ReadLine());
        switch (digit)
        {
            case 1:
                Console.Write("You Entered one ");
                break;
            case 2:
                Console.Write("You Entered two ");
                break;
            case 3:
                Console.Write("You Entered three ");
                break;
            default:
                Console.Write("You Entered greater then one two three ");
                break;
        }
        
    }
}