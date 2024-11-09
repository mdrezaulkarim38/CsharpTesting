namespace CsharpTesting.AllProgramFiles.Pattern;

public class RPattern
{
    public void PatternPrint(int n)
    {
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}