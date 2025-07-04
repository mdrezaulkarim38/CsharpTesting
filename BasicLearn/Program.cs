using System;
namespace BasicLearn;

public class Program
{
    static void Main(string[] args)
    {
        int i = 23;
        double d = 4.3443;
        char c = 'a';
        string name = "Rezaul Karim";
        bool isTodayOffDay = true;
        Console.WriteLine($"Name is: {name}. I value {i} d value is {d}");
        Console.WriteLine(c + " " + isTodayOffDay);
    }
}