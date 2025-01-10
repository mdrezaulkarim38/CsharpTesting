using System;
namespace Basic;

public class Animal
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Pig : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The pig makes a sound: wee wee");
    }
}

public class Dog : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog makes a sound: bow wow");
    }
}

public class SomeClass
{
    private int someValue;

    public SomeClass(int val)
    {
        someValue = val;
    }
    public static SomeClass operator +(SomeClass arg1, SomeClass arg2)
    {
        return new SomeClass(arg1.someValue + arg2.someValue);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var x = 1 + 2;
        var o1 = new SomeClass(10);
        var o2 = new SomeClass(20);
        var o3 = o1 + o2;
        Console.WriteLine(o3);
        Console.WriteLine("Hello World!");
    }
}