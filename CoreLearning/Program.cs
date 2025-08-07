namespace CsharpTesting.CoreLearning
{
    public class Program
    {
        static void reverseArray(int[] arr)
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