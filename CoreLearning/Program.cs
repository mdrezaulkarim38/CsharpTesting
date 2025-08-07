namespace CsharpTesting.CoreLearning
{
    public class Program
    {
        static int Setmini(int[] A, int N)
        {
            int mini = A[0];
            for (int i = 1; i < N; i++)
            {
                mini = mini > A[i] ? A[i] : mini; 
            }

            return mini;
        }
        static int SetMax(int[] A, int N)
        {
            int max = A[0];
            for (int i = 1; i < N; i++)
            {
                max = max < A[i] ? A[i] : max; 
            }

            return max;
        }

        static void bubbleSort(int[] arr, int n){
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++) {
                swapped = false;
                for (j = 0; j < n - i - 1; j++) {
                    if (arr[j] > arr[j + 1]) {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
        }
        static int KthSmallest(int[] arr, int k)
        {
            bubbleSort(arr, arr.Length);
            return arr[k-1];
        }
        static void Main(string[] args)
        {
            int[] arr = [2, 3, 1, 20, 15];
            int k = 4;
            Console.WriteLine(KthSmallest(arr, k));
            
        }
    }
}