using System.IO.Pipelines;

namespace Basic;

public class Problems{
    public int SumOfDigitsOfANumber(int n)
    {
        /* int ans = 0;
        while(n > 0){
            int digit = n % 10;
            ans += digit;
            n /= 10;
        }
        return ans; */

        if(n == 0)
        {
            return 0;
        }
        return n % 10 + SumOfDigitsOfANumber(n / 10);
    }

    public bool IsPrime(int n){
        /* if(n == 1 || n == 0){
            return false;
        }
        for(int i = 2; i < n; i++){
            if(n % i == 0){
                return false;
            }
        }

        return true; */

        if(n <= 1){
            return false;
        }
        for(int i = 2; i <= Math.Sqrt(n); i++){
            if(n % i == 0){
                return false;
            }
        }
        return true;
    }

    public bool IsPower(int x, int y)
    {
        /* if(x == 1) return (y == 1);

        int pow = 1;
        while (pow < y)
        {
            pow = pow * x;
        }
        return (pow == y); */

        double res1 = Math.Log(y) / Math.Log(x);
        double res2 = Math.Log(y) / Math.Log(x);
        return (res1 == res2);
    }

    public double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    }

    public bool IsValidTriangle(int a, int b, int c)
    {
        if( (a + b) <= c || (a + c) <= b || (b + c) <= a) {
            return false;
        }
        return true;
    }
}