using System;

public class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);
        
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            
            // Check if y is either x + 1 or if y is less than x + 1 and the difference is a multiple of 9
            if (y == x + 1 || (y < x + 1 && (x + 1 - y) % 9 == 0))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}