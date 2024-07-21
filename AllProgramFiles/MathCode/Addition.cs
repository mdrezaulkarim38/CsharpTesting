/*
*Now We are going to try this one 
* 1 + 2 + 3 + 4 + 5 + 6 + .... + n = ?
* 1 + 2 + 3 = 6 if n = 3
*/

namespace CsharpTesting.AllProgramFiles.MathCode;
public class Addition
{
    public void displayCalculation()
    {
        Console.WriteLine("Enter N value number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        // Now We are going to try for loop
        int sum = 0;
        for(int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("The addition of n : "+ sum);
    }
}