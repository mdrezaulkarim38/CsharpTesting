namespace Basic;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1st Statement: ");
        goto label1;
        Console.WriteLine("2nd Statement: ");
        label1:
            Console.WriteLine("3rd statement: ");

        Console.WriteLine("End of Main Method Statement");
    
    }
}