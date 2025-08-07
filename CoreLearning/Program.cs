namespace CsharpTesting.CoreLearning
{
    public class Program
    {
        static void reverseArray(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
            {
                temp[i] = arr[n - i - 1];
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = temp[i];
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            reverseArray(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}