public class LeapYear
{
    public void getLeapYear()
    {
        Console.Write("Enter a Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if(year % 400 == 0)
        {
            Console.WriteLine($"{year} is leap year");
        }
        else if(year % 100 == 0)
        {
            Console.WriteLine($"{year} is not leap year");
        }
        else if(year % 4 == 0)
        {
            Console.WriteLine($"{year} is leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not leap year");
        }
    }
}