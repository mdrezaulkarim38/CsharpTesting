namespace CoreLearning.Linqs;

public class LinqCode
{
    public void TestIEnumerable()
    {
        List<Student> studentList = new List<Student>()
        {
            new Student(){ID = 1, Name = "James", Gender = "Male"},
            new Student(){ID = 2, Name = "Sara", Gender = "Female"},
            new Student(){ID = 3, Name = "Steve", Gender = "Male"},
            new Student(){ID = 4, Name = "Pam", Gender = "Female"}
        };

        IEnumerable<Student> QuerySyntax = from std in studentList where std.Gender == "Male" select std;

        foreach (var student in QuerySyntax)
        {
            Console.WriteLine($"ID: {student.ID}, Name : {student.Name}");
        }

    }

    public void TestIQueryable()
    {
        List<Student> studentList = new List<Student>()
        {
            new Student(){ID = 1, Name = "James", Gender = "Male"},
            new Student(){ID = 2, Name = "Sara", Gender = "Female"},
            new Student(){ID = 3, Name = "Steve", Gender = "Male"},
            new Student(){ID = 4, Name = "Pam", Gender = "Female"}
        };

        IQueryable<Student> MethodSyntax = studentList.AsQueryable().Where(std => std.Gender == "Male");

        foreach (var student in MethodSyntax)
        {
            Console.WriteLine($"ID: {student.ID}, Name : {student.Name}");
        }

    }

    public void TestingExtension()
    {
        List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // IEnumerable<int> EvenNumbers = Enumerable.Where(intList, n => n % 2 == 0);
        var evenNumbers = intList.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers: " + string.Join(",", evenNumbers));

        var squares = intList.Select(n => n * n);
        Console.WriteLine("Squares: " + string.Join(",", squares));

        var decending = intList.OrderByDescending(n => n);
        Console.WriteLine("Decending: " + string.Join(",", decending));

        Console.WriteLine("Sum: " + intList.Sum());
        Console.WriteLine("Min: " + intList.Min());
        Console.WriteLine("Max: " + intList.Max());
        Console.WriteLine("Average: " + intList.Average());

        Console.WriteLine("First: " + intList.FirstOrDefault());
        Console.WriteLine("Last: " + intList.LastOrDefault());

        var duplicateList = new List<int> { 1, 2, 3, 3, 4 };
        var distinct = duplicateList.Distinct();
        Console.WriteLine("Distinct: " + string.Join(",", distinct));

        
    }
}

public class Student
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Gender { get; set; }
}

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? City { get; set; }
}