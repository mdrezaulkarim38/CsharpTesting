namespace CsharpTesting.AllProgramFiles.NumberTheory;
public class Numbers
{
    public Boolean IsPrimeNumber(int n)
    {
        if(n <= 1){
            return false;
        }
        for(int i = 2; i * i <= n; i++)
        {
            if(n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    public int gcd(int a, int b)
    {
        if(a % b == 0) {
            return b;
        }
        return gcd(b, a % b);
    }
}