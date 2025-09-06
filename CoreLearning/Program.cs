using System;
using CoreLearning.OopPrinciples.ClassFiles;

namespace CoreLearning;

public class Program
{
    static void Main()
    {
        Test obj = new Test();
        Console.WriteLine($"i = {obj.i}");
        Console.WriteLine($"s = {obj.s}");
        Console.WriteLine($"b = {obj.b}");

        if (obj.s == null)
        {
            Console.WriteLine("s = null");
        }
        
    }
}