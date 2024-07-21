namespace CsharpTesting.AllProgramFiles;
public class OddEven
{
    public void OddEvenDisplay()
    {
        Console.Write("Enter a integer Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number % 2 == 0)
        {
            Console.WriteLine($"{number} is even");
        }else{
            Console.WriteLine($"{number} is odd");
        }
    }
}