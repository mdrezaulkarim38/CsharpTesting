namespace CsharpTesting.AllProgramFiles
{
    public class Variables
    {
        int y;
        public static void VariableView()
        {
            int x = 32;
            Console.WriteLine("Value Of x is : "+x);
            
            Variables variables = new Variables();
            Console.WriteLine("Value of y is : "+ variables.y);
        }
    }
}