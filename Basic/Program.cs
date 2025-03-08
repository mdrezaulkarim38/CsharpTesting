namespace Basic;
public class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        Console.WriteLine($"The factorial of {x} is {Fun(x)}");
    }

    static int Fun(int n)
    {
        int result  = 0;
        for(int i = 1; i <= n; i++)
        {
            result = result + 1;
        }
        return result;
    }
}
