using System;
namespace BasicLearn;

class sample
{
    public sample()
    {
        Console.WriteLine("constructor 1 called");
    }
    public sample(int x)
    {
        int p = 2;
        int u;
        u = p + x;
        Console.WriteLine("constructor 2 called");
    }
}
class Program
{
    static void Main(string[] args)
    {
        sample s = new sample(4);
        sample t = new sample();
    
    }
}
