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
        int[] marray = {1, 2, 3}; // array (fixed, strongly typed)
        ArrayList mylist = new ArrayList();// arraylist (flexible)
        mylist.Add(1);
        mylist.Add(3);

        // strongly type, size is flexible
        List<int> geneint = new List<int>();
        geneint.Add(1);
        geneint.Add(2);
        try
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
        }
    }
}