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
        static void Main(string[] args)
        {
            int[] A = { 4, 9, 6, 5, 2, 3 };
            int N = 6;
            
            Console.WriteLine(Setmini(A, N));
            Console.WriteLine(SetMax(A, N));
        }
    }
}