namespace Basic;


public class Program
{
    public  static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        (a, b) = (b , a);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}