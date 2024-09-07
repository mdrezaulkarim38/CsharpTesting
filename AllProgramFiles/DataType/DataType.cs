using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpTesting.AllProgramFiles.DataType
{
    public class DataType
    {
        public void viewDataTypes()
        {
            char a = 's';
            int i = 89;
            short s = 56;
            long l = 4556;
            uint ui = 95;
            ushort us = 76;
            ulong ul = 3624573;
            double d = 8.358674532;
            float f = 3.7333f;
            decimal dec = 389.5m;

            Console.WriteLine("Char: "+ a);
            Console.WriteLine("integer: "+ i);
            Console.WriteLine("Short: "+ s);
            Console.WriteLine("Long: "+ l);
            Console.WriteLine("float: "+ f);
            Console.WriteLine("double : "+ d);
            Console.WriteLine("decimal : "+ dec);
            Console.WriteLine("Unsigned Integer: "+ ui);
            Console.WriteLine("Unsinged short: "+ us);
            Console.WriteLine("Unsinged long"+ ul);
        }

        public void viewDataTypeIncrement()
        {
            
        }
    }
}