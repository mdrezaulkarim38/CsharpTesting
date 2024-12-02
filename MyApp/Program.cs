namespace MyApp;
public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.Break();
        car.SlowDown();
        Console.WriteLine("Testing the code");
    }
}

public class Car
{
    public string _Name = "Shuvo";
    private int _Speed = 23;
    int _Weight = 44;
    public void Break(){
        Console.WriteLine("Break "+ _Speed);
    }
    public void SlowDown(){
        Console.WriteLine("Name & Weight "+ _Name + ""+ _Weight);
    }
}