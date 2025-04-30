using System;
using System.Collections.Generic;

namespace BasicCS;

public class Program
{
    static List<int> findTwoElements(int[] arr)
    {
        int n = arr.Length;
        int[] freq = new int[n + 1];
        int repeting = -1;
        int missing = -1;
        for (int i = 0; i < n; i++)
        {
            freq[arr[i]]++;
        }

        for (int i = 0; i <= n; i++)
        {
            if (freq[i] == 0)
            {
                missing = i;
            }
            else if (freq[i] == 2)
            {
                repeting = i;
            }
        }
        
        return new List<int> { repeting, missing };
    }

    static void Main()
    {
        int[] arr = { 3, 1, 3 };
        List<int> ans = findTwoElements(arr);
        Console.WriteLine(ans[0] + " " + ans[1]);
    }
}