namespace CoreLearning.OopPrinciples.ClassFiles;

public class Employee
{
    public int Id, Age;
    public string Address, Name;
    public bool IsPermanent;

    public Employee()
    {
        Id = 100;
        Age = 30;
        Address = "123 Main St";
        Name = "Shuvo";
        IsPermanent = true;
    }
    public void Display()
    {
        Console.WriteLine($"Id = {Id}");
        Console.WriteLine($"Age = {Age}");
        Console.WriteLine($"Address = {Address}");
        Console.WriteLine($"IsPermanent = {IsPermanent}");
        Console.WriteLine($"Name = {Name}");
    }
}