namespace CsharpTesting.AllProgramFiles;
public class SimpleInput
{
    public void UserInput()
    {
        int a, b;
        Console.Write("Enter value of a : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of b : ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The total Some of a + b = {a + b}");
    }
}