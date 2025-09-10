namespace CoreLearning.LogicalProgram.Fibonacci;

public class FibonacciCode
{
    public void FibonacciSeries(int firstNumber, int secondNumber, int counter, int number)
    {
        Console.Write(firstNumber + " ");
        if (counter < number)
        {
            FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);
        }
    }

    public int NthFibonacciNumber(int number)
    {
        if ((number == 0) || (number == 1))
        {
            return number;
        }
        else
        {
            return (NthFibonacciNumber(number - 1) + NthFibonacciNumber(number - 2));
        }
    }

    public int NthFibonacciNumber2(int number)
    {
        int firstNumber = 0, secondNumber = 1, nextNumber = 0;        
        if (number == 0)
            return firstNumber;
        for (int i = 2; i <= number; i++)
        {
            nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
        return secondNumber;
    }
}