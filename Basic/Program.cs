using System;

namespace Basic;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }

    class Patient
    {
        public string? Name { get; set;  }
        public string? Address { get; set; }
        public Doctor? DoctorWhileTreat { get; set; }
    }

    class Doctor
    {
        public string? Name { get; set; }
    }
}