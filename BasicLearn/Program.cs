using System;
namespace BasicLearn;

public class Program
{
    public static void Main()
    {
        classA a = new classC();
        console.WriteLine(a.Print());
    }
    public class classA
    {
        public virtual string Print()
        {
            return "classA";
        }
    }

    public class classB : classA
    {
        public override string Print()
        {
            return "classB";
        }
    }
    public class classC : classB
    {
        public override string Print()
        {
            return "ClassC";
        }
    }
}