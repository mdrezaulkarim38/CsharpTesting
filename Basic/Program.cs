namespace Basic;
public class Program
{
    public static void Main(string[] args)
    {
        int a = 15;
        UpdateValue(a);
        Console.WriteLine(a);
    }
    private static void UpdateValue(int b)
    {
        b = 30;
    }
}

public class Employee
{
    public int EmployeeID;
    public string Name;
}