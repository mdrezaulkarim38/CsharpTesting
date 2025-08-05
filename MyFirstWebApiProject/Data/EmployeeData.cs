using MyFirstWebApiProject.Models;
namespace MyFirstWebApiProject.Data;

public static class EmployeeData
{
    public static List<Employee> Employees = new List<Employee>
    {
        new Employee { Id = 1, Name = "Alice Johnson", Gender = "Female", Department = "HR", City = "New York" },
        new Employee { Id = 2, Name = "Bob Smith", Gender = "Male", Department = "IT", City = "Los Angeles" },
        new Employee { Id = 3, Name = "Charlie Davis", Gender = "Male", Department = "Finance", City = "Chicago" },
        new Employee { Id = 4, Name = "Sara Taylor", Gender = "Female", Department = "HR", City = "Los Angeles" },
        new Employee { Id = 5, Name = "James Smith", Gender = "Male", Department = "IT", City = "Chicago" },
    };
}