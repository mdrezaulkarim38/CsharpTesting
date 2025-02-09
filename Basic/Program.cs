using System;

public class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string w = Console.ReadLine().Trim();
            string plural = w.Substring(0, w.Length - 2) + "i";
            Console.WriteLine(plural);
        }
    }
}