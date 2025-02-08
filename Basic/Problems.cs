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
}