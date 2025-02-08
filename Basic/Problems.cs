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
}