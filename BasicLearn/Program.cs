using System;
namespace BasicLearn;


class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        fun1(ref a);
        Console.WriteLine(a);
    }
    static void fun1(ref int a)
    {
        a = a * a;
    }
}
