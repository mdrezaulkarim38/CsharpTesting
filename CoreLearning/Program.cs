namespace CoreLearning;

public static class Program
{
    public static void Main(string[] args)
    {
        char letter;
        Console.WriteLine("Enter any letter: ");
        letter = Convert.ToChar(Console.ReadLine());
        letter = char.ToLower(letter);
        if (letter == 'a' || letter == 'i' || letter == 'o' || letter == 'e'  || letter == 'u')
        {
            Console.WriteLine("You entered vowel character."+letter);
        }
        else
        {
            Console.WriteLine("You entered consonant character."+letter);
        }

    }
}