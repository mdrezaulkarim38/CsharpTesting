using System;
namespace CsharpTesting
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog says: bow wow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
       
    }
}