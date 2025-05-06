using System;
namespace BasicCS;

public delegate void SampleDelegate();
public class Program
{
    static void Main(string[] args)
    {
        SampleDelegate sm = new SampleDelegate(SampleMethodOne);
        SampleDelegate sm1 = new SampleDelegate(SampleMethodTwo);
        SampleDelegate sm2 = new SampleDelegate(SampleMethodThree);
        SampleDelegate del3 = sm + sm1 + sm2 - sm1;
        del3();
        Console.WriteLine("Hello To World");
    }
    public static void SampleMethodOne()
    {
        Console.WriteLine("SampleMethod one Invoked");
    }
    public static void SampleMethodTwo()
    {
        Console.WriteLine("SampleMethod Two Invoked");
    }

    public static void SampleMethodThree()
    {
        Console.WriteLine("Sample Method Three Invoked");
    }
}