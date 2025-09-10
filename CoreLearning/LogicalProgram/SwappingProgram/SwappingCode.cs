namespace CoreLearning.LogicalProgram.SwappingProgram;

public class SwappingCode
{
    public void SwappingValue(int number1, int number2)
    {
        Console.WriteLine($"Before SWapping number1 = {number1}, number2 = {number2}");
        int temp = number1;
        number1 = number2;
        number2 = temp;
        Console.WriteLine($"after SWapping number1 = {number1}, number2 = {number2}");
    }

    public void SwappingValueMulDiv(int number1, int number2)
    {
        Console.WriteLine($"Before SWapping number1 = {number1}, number2 = {number2}");
        number1 = number1 * number2;
        number2 = number1 / number2;
        number1 = number1 / number2;
        Console.WriteLine($"after SWapping number1 = {number1}, number2 = {number2}");
    }

    public void SwappingValueAddSub(int number1, int number2)
    {
        Console.WriteLine($"Before SWapping number1 = {number1}, number2 = {number2}");
        number1 = number1 + number2;
        number2 = number1 - number2;
        number1 = number1 - number2;
        Console.WriteLine($"after SWapping number1 = {number1}, number2 = {number2}");
    }
    public void StringSwapping(string str1, string str2)
    {
        Console.WriteLine($"Before SWapping str1 = {str1}, str2 = {str2}");
        str1 = str1 + str2;
        str2 = str1.Substring(0, str1.Length - str2.Length);
        str1 = str1.Substring(str2.Length);
        Console.WriteLine($"after SWapping str1 = {str1}, str2 = {str2}");
    }
}