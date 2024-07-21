/*
* Now this calculation I am going to implement 
* 1^2 + 2^2 + 3^2 + 4^2 + 5^2 + 6^2 + .... + n^2 = ?
* 1^2 + 2^2 + 3^2 = 14 if n = 3
*/

namespace CsharpTesting.AllProgramFiles.MathCode;
public class SquareAddition
{
    public void displayCalculation()
    {
        // need to Print for N value
        Console.Write("Enter the value of N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        // Total store in sum
        int sum = 0;
        // Now the calculation part
        for(int i = 1; i <= n; i++)
        {
            sum += (i * i); // we know that 1^2 = 1 * 1 and 2 ^ 2 = 2 * 2 and 3 ^ 2 = 3 * 3
        }

        // Out put area
        Console.WriteLine("The Total of this N value: "+ sum);
    }
}