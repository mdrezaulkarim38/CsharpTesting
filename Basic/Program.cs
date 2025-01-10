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

public class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal pig = new Pig();
        Animal myDog = new Dog();
        
        myAnimal.AnimalSound();
        myDog.AnimalSound();
        pig.AnimalSound();
        Console.WriteLine("Hello World!");
    }
}