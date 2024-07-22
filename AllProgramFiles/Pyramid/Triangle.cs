namespace CsharpTesting.AllProgramFiles.Pyramid;
public class Triangle
{
    public void getTriangle()
    {
        Console.WriteLine("Enter n value: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}