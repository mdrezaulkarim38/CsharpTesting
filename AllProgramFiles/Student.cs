using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpTesting.AllProgramFiles
{
    class X {
        protected int x;
        public X()
        {
            x = 10;
        }
    }
    class Y : X 
    {
        public int getX()
        {
            return x;
        }
    }
    public class Student
    {
        public int rollNo;
        public string name;

        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }
        public int getRollNo()
        {
            return rollNo;
        }
        public string getName()
        {
            return name;
        }
    }
}