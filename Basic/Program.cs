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

    
    public static void Main(string[] args){
        int n = 101;
        if (IsEven(n) == true)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}