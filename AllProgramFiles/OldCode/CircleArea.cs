namespace CsharpTesting.AllProgramFiles;

public class CircleArea
{
    public void DisplaySomeThing()
    {
        double r, area, pi;
        r = Convert.ToDouble(Console.ReadLine());
        pi = Math.Acos(-1);
        area = pi * r * r;
        Console.WriteLine($"Area is {area}");
    }
}
