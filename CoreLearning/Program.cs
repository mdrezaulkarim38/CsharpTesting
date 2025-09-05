using System;
namespace CoreLearning;

public class Program
{
    public static void reverseArray(int[] arr)
    {
        Array.Reverse(arr);
    }

    static void Main()
    {
        int[] arr = { 1, 4, 3, 2, 6, 5 };
        reverseArray(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}