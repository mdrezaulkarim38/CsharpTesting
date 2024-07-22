namespace CsharpTesting.AllProgramFiles.MaxNumber;
public class MaxBetweenNumber
{
    public void getMaxTwoNumber()
    {
        Console.WriteLine("Enter First number: ");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        if(numberOne == numberTwo)
        {
            Console.WriteLine("Both are Equal");
        }
        else if(numberOne > numberTwo)
        {
            Console.WriteLine($"First number is greater {numberOne}");
        }
        else if(numberTwo > numberOne)
        {
            Console.WriteLine($"Second number is greater {numberTwo}");
        }
        else
        {
            Console.WriteLine("Known Value");
        }
    }
    public void getMaxThreeNumber()
    {
        // 1 > 2 1 > 1
        Console.WriteLine("Enter First number: ");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int numberThree = Convert.ToInt32(Console.ReadLine());
        if(numberOne >= numberTwo)
        {
            if(numberOne >= numberThree)
            {
                Console.WriteLine($"First number is greater {numberOne}");
            }
            else if(numberTwo >= numberThree)
            {
                Console.WriteLine($"Second number is greater {numberTwo}");
            }
            else 
            {
                Console.WriteLine($"Third number is greater {numberThree}");
            }
        }
        
    }
}