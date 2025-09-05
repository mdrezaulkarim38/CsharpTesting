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
    static void Print(string str)
    {
        Console.Write(str);
    }
    static void Println(string str)
    {
        Console.WriteLine(str);
    }
    static void Main()
    {
        bool isValid = true;
        Println(isValid.ToString());
        sbyte level = 127;
        Println(level.ToString());
    }
}