namespace Basic;


public class Program
{
    public  static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        // int sum = ((n * (n + 1)) / 2);
        int sum = 0;
        if(n % 2 == 0)
        {
            sum = (n / 2) * (n + 1);
        }
        else
        {
            sum = ((n + 1) / 2) * n;
        }
        Console.WriteLine(sum);
    }
}