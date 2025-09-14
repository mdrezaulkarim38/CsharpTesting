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
        
    }
}

public class Student
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Gender { get; set;  }
}