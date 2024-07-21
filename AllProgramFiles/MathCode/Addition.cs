/*
* Today I am going to show you this math work
* 1 + 2 + 3 + 4 + 5 + 6 + .... + n = ?
* 1 + 2 + 3 = 6 if n = 3
*/

namespace CsharpTesting.AllProgramFiles.MathCode;
public class Addition
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
            sum += i;
        }
        Console.WriteLine("The Total of this N value: "+ sum);
    }
}