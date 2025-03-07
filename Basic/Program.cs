namespace Basic;
public class Program
{
    static void Main(string[] args)
    {
        Employee em = new Employee();
        em.EmployeeID = 1001;
        em.Name = "John";

        Employee em2 = new Employee();
        em2.Name = "Smith";
        Console.WriteLine($"Emp1 Name = {em.Name}");
        Console.WriteLine($"Emp2 name = {em2.Name}");
    }
}

public class Employee
{
    public int EmployeeID;
    public string Name;
}