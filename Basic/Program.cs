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

    static int ClosestNumber(int n, int m)
    {
        int closest = 0;
        int minDifference = int.MaxValue;
        for(int i = n - Math.Abs(m); i <= n + Math.Abs(m); ++i)
        {
            if(i % m == 0)
            {
                int difference = Math.Abs(n - i);
                if(difference < minDifference || (difference == minDifference && Math.Abs(i) > Math.Abs(closest))){
                    closest = i;
                    minDifference = difference;
                }
            }
        }
        return closest;
    }

    static int OppositeFaceOfDice(int n){
        int ans = 7 - n;
        return ans;
    }

    static bool CheckIsAP(int[] arr, int n)
    {
        if(n == 1) {
            return true; // is the the Length of array
        }
        Array.Sort(arr);
        int difference = arr[1] - arr[0];
        for(int i = 2; i < n; i++)
        {
            if(arr[i] - arr[i - 1] != difference) {
                return false;
            }
        }
        return true;
    }


    static float SumOfGP(float a, float r, float n)
    {
        /* float sum = 0;
        for(int i = 0; i < n; i++)
        {
            sum = sum + a;
            a = a * r;
        }
        
        return sum;  */
        return (a * (1 - (int)(Math.Pow(r, n)))) / (1 - r);
    }

    public static float SimpleInterest(float p, float t, float r) {
        return (p * t * r) / 100;
    }

    static float FindArea(float r)
    {
        return (float)(Math.PI * r * r);
    }

    public static void Main(string[] args){
        // int n = 101;
        // if (IsEven(n) == true)
        //     Console.WriteLine("true");
        // else
        //     Console.WriteLine("false");

        // int a = 2, b = 3;
        // (a, b) = (b, a);
        // Console.WriteLine(a +" "+b);

        Problems p = new Problems();
        /* Console.WriteLine("Answer of the 687 = "+ p.SumOfDigitsOfANumber(687));
        Console.WriteLine("Answer of the 12 = "+ p.SumOfDigitsOfANumber(12));  

        Console.WriteLine("n = 10 is prime = "+ p.IsPrime(10));    
        Console.WriteLine("n = 11 is prime = "+ p.IsPrime(11));
        Console.WriteLine("n = 1 is prime = "+ p.IsPrime(1));
        Console.WriteLine("n = 0 is prime = "+ p.IsPrime(0)); */

        int  a = 15, b = 20;
        Console.WriteLine("LCM of "+ a +" and "+ b +" is "+ p.LCM(a, b));
            
    }
}