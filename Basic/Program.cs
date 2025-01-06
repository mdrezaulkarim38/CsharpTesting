namespace Basic;

public class Program
{
    static List<SomeClass> x = new List<SomeClass>();
    static void Main(string[] args)
    {
        Console.WriteLine("This is testing");
        Console.WriteLine("Press Enter to start");
        Console.Read();
        for(double i = 0; i < 100000000000; i++)
        {
            SomeClass x = new SomeClass();
            x.SomeData = DateTime.Now.ToString();
        }
    }
}