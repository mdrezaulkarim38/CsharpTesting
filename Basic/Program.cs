namespace Basic;


public class Program
{
    public static bool IsEven(int n){
        return (n % 2 == 0);
    }

    static void PrintTable(int n, int i = 1){
        if(i == 11) {
            return ;
        }
        Console.WriteLine($" {n} * {i} = {n * i}");
        i++;
        PrintTable(n, i);
    }

    static int FindSum1(int n)
    {
        int sum = 0;
        for(int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }

    static int FindSum2(int n)
    {
        if(n % 2 == 0){
            return (n / 2) * (n + 1);
        }
        else{
            return ((n + 1) /2) * n;
        }
    }

    public static void Main(string[] args){
        int n = 101;
        if (IsEven(n) == true)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");


            
    }
}