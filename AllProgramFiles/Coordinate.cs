namespace CsharpTesting.AllProgramFiles;
public class Coordinate
{
    public void CalculateCoordinate()
    {
        Console.Write("Enter the first one: ");
        double CoFirst = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second one: ");
        double ConSecond = Convert.ToDouble(Console.ReadLine());
        double distance = CoFirst > ConSecond ? CoFirst - ConSecond : ConSecond - CoFirst;
        Console.WriteLine("This is distance: "+ distance);
    }
}