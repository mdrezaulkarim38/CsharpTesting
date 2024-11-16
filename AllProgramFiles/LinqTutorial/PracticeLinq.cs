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
        
    }
        
}