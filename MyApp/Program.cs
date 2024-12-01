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
    string Name = "Shuvo";
    int Speed = 23;
    int Weight = 44;
    public void Break(){
        Console.WriteLine("Break "+ Speed);
    }
    public void SlowDown(){
        Console.WriteLine("Name & Weight "+ Name + ""+ Weight);
    }
}