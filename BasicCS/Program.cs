using System;
namespace BasicCS;

public class Program
{
    public const int cmToMeter = 100;
    public readonly double PI = 3.1;
    static void Main(string[] args)
    {
        
    }
}

public class Employee
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public virtual void Validate() 
    {
        CheckName();
        CheckAddress();
    }

    private void CheckName() 
    {

    }
    private void CheckAddress()
    {

    }
}

public class Manager : Employee
{
    public override void Validate()
    {
        base.Validate();
    }
}