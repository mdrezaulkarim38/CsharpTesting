namespace CsharpTesting.AllProgramFiles.NumberTheory;
public class PrimeNumber
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
}