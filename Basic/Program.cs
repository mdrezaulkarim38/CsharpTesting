using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);
        
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] input = Console.ReadLine()!.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] a = input.Select(int.Parse).ToArray();
            
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int num in a)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }
            
            bool possible = true;
            var sortedKeys = freq.Keys.OrderBy(x => x).ToList();
            foreach (int x in sortedKeys)
            {
                int countX = freq[x];
                if (countX == 0)
                    continue;
                    
                if (freq.TryGetValue(x + 1, out int countXPlus1))
                {
                    if (countX > countXPlus1)
                    {
                        possible = false;
                        break;
                    }
                    freq[x + 1] -= countX;
                }
                else
                {
                    if (countX % 2 != 0)
                    {
                        possible = false;
                        break;
                    }
                }
            }
            
            Console.WriteLine(possible ? "YES" : "NO");
        }
    }
}