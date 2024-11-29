using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _.AllProgramFiles.LinqTutorial;
public class PracticeLinq
{
    public void DisplayData()
    {
        List<string> list = new List<string>()
        {
              " Hii JavaTpoint",  
            " Welcome to JavaTpoint ",  
            " The topic is LINQ ",  
            " Any Queries "
        };

        var r = from I in list where I.Contains("JavaTpoint") select I;
        foreach(var i in r)
        {
            Console.WriteLine(i);
        }

        List<int> intList = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10,11,12
        };

        var queries = from i in intList where i > 5 select i;
        foreach(var q in queries)
        {
            Console.WriteLine(q);
        }
        Console.WriteLine("New Query ");
        var MethodSyntax = intList.Where(i => i > 5 && i < 11).ToList();
        foreach(var method in MethodSyntax)
        {
            Console.WriteLine(method);
        }
    }
        
}