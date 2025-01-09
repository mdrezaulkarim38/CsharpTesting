using System;
using System.Collections;
using System.Collections.Generic;
namespace Basic;

public class Program
{
    static void Main(string[] args)
    {
        //        int  i = 10;
        //        double d2 = i; // casting (implicit casting)
        //        double d1 = 3;
        //        int y = (int) d1; // explicit casting
        /*int[] marray = {1, 2, 3}; // array (fixed, strongly typed)
        ArrayList mylist = new ArrayList();// arraylist (flexible)
        mylist.Add(1);
        mylist.Add(3);

        // strongly type, size is flexible
        List<int> geneint = new List<int>();
        geneint.Add(1);
        geneint.Add(2);*/
       /* try
        {
            int y = 0;
            int x = 1 / y;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("Clean up code");
        }*/
       int add = 0;
       int sub = 0;
       MyMaths(10,10,out add, out sub);
       Console.WriteLine("The addition is: "+add);
       Console.WriteLine("The subtraction is: "+sub);
    }
    static void MyMaths(int num1, int num2, out int add, out int sub) // If you want to return multipule outputs from a function you can use OUT Keyword
    {
        add = num1 + num2;
        sub = num1 - num2;
    }
}