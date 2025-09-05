using System;
namespace CoreLearning;

public struct Pair
{
    public int min;
    public int max;
}

public class Program
{
    public static Pair GetMinMax(int[] arr, int n)
    {
        Pair minimax = new Pair();
        Array.Sort(arr);
        minimax.min = arr[0];
        minimax.max = arr[n - 1];

        return minimax;
    }
    public static void reverseArray(int[] arr)
    {
        Array.Reverse(arr);
    }

    public static void reverseArrayCustom(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
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