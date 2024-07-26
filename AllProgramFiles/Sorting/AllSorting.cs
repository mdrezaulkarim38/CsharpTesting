namespace CsharpTesting.AllProgramFiles.Sorting;
public class AllSorting
{
    public void InsertionSort(int[] arr)
    {
        int arrSize = arr.Length;
        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        for(int i = 0; i < arrSize; i++)
        {
            int x = arr[i];
            int j = i - 1;
            while(j >= 0 && arr[j] > x)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = x;
        }

        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
}