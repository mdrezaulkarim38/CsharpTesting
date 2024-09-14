namespace CsharpTesting.AllProgramFiles
{
    public class Variables
    {
        readonly int y;
        public static void VariableView()
        {
            int x = 32;
            Console.WriteLine("Value Of x is : "+x);
            
            Variables variables = new Variables();
            Console.WriteLine("Value of y is : "+ variables.y);
        }
        public static void VariableInput()
        {
            Console.WriteLine("Enter a value: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of enter is : "+ x);
        }
    }
}