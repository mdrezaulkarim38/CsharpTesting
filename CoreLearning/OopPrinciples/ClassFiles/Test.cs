namespace CoreLearning.OopPrinciples.ClassFiles;

public class Test
{
    private readonly int _i;
    private readonly bool _b;
    private readonly string _s;

    public Test(int i, bool b, string s)
    {
        _i = i;
        _b = b;
        _s = s;
    }
    public void Display()
    {
        Console.WriteLine($"i = {_i}");
        Console.WriteLine($"b = {_b}");
        Console.WriteLine($"s = {_s}");
    }
}