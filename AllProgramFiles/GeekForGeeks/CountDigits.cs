namespace CsharpTesting.AllProgramFiles.GeekForGeeks;
public class CountDigits
{
    public int CountNumber(int n)
    {
        int result = 0;
        while(n > 0)
        {
            n /= 10;
            result++;
        }
        return result;
    }
}