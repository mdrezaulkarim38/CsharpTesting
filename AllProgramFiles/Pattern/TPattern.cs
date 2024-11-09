using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _.AllProgramFiles.Pattern
{
    public class TPattern
    {
        public void PatternPrint(int n)
        {
            for(int i =0; i <= n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void PatternPrintNumber(int n)
        {
            for(int i =1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void PatternPrintINumber(int n)
        {
            for(int i =1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void Pattern7(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for(int j = 0; j < 2 * i+1; j++)
                {
                    Console.Write("*");
                }
                for(int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
        public void Pattern8(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < 2 * n -(2*i+1); j++ )
                {
                    Console.Write("*");
                }
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}