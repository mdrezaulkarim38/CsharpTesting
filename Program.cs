/* using CsharpTesting.AllProgramFiles;
using CsharpTesting.AllProgramFiles.MathCode;
using CsharpTesting.AllProgramFiles.MaxNumber;
using CsharpTesting.AllProgramFiles.NumberTheory;
using CsharpTesting.AllProgramFiles.Pyramid; */
//using CsharpTesting.AllProgramFiles.Sorting;
using CsharpTesting.AllProgramFiles;
//using CsharpTesting.AllProgramFiles.DataType;
public class Program
{
    /* public static void AddStr(dynamic s1, dynamic s2)
    {
        Console.WriteLine(s1 + s2);
    } */
    public static void Main(string[] args)
    {
        /*
        SimpleInput simpleInput= new SimpleInput();
        simpleInput.UserInput();
        CircleArea circleArea= new CircleArea();
        circleArea.DisplaySomeThing();
        Coordinate coordinate= new Coordinate();
        coordinate.CalculateCoordinate();
        OddEven oddEven= new OddEven();
        oddEven.OddEvenDisplay();
        LeapYear leapYear = new LeapYear();
        leapYear.getLeapYear();
        Addition addition = new Addition();
        addition.displayCalculation();
        SquareAddition squareAddition = new SquareAddition();
        squareAddition.displayCalculation();
        Triangle triangle = new Triangle();
        triangle.getTriangle();
        MaxBetweenNumber maxBetweenNumber = new MaxBetweenNumber();
        maxBetweenNumber.getMaxTwoNumber();
        maxBetweenNumber.getMaxThreeNumber();
        */
        /* Numbers numbers= new Numbers();
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if(numbers.IsPrimeNumber(n)){
            Console.WriteLine("Number is prime");
        }
        else
        {
            Console.WriteLine("Number is not prime");
        } */
        /* AllSorting allSorting = new AllSorting();
        allSorting.InsertionSort([5,8,3,1,7,2,9,6,4]); */
        /* DataType.ViewDataTypes();
        DataType.ViewDataTypeIncrement();
        DataType.Boolean();
        DataType.StringPrint(); */

        /* Variables.VariableView();
        Variables.VariableInput(); */

        /**
        * Dynamic variable 
        
        AddStr("Shuvo", "Farhana");
        AddStr("Husband", "Wife");
        AddStr("Hello ", 123);
        AddStr(12, 30);*/


        /* Student student = new Student(1, "Shuvo");
        Console.WriteLine("Roll number: {0}", student.rollNo);
        Console.WriteLine("Name : {0}", student.name);

        Console.WriteLine();
        Console.WriteLine("Roll number: {0}", student.getRollNo());
        Console.WriteLine("Name: {0}", student.getName());

        X obj1 = new X();
        Y obj2 = new Y();
        Console.WriteLine("Value of x is : {0}", obj2.getX()); */

        int num = 2020;
        object obj = num;
        //num = 100;
        int i = (int)obj;
        //System.Console.WriteLine("Value - type value of num is : {0}", num);
        System.Console.WriteLine("Object - type value of obj is : {0}", obj);
        System.Console.WriteLine("Object - type value of i is : {0}", i);
        

    }
}
