using Microsoft.Data.SqlClient;

namespace Basic;

public class Program
{
    static void Main(string[] args)
    {
        string connectionString = @"Server=localhost,1433;Database=test;User Id=sa;Password=Shuvo123;TrustServerCertificate=True;";
        
        string query = @"
            SELECT 
                e.Name AS EmployeeName, 
                e.Email, 
                e.Gender, 
                e.Salary, 
                d.Name AS DepartmentName, 
                d.Location 
            FROM Employees e
            INNER JOIN Departments d ON e.DepartmentId = d.ID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connected to EF_Demo_DB successfully!\n");

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string empName = reader["EmployeeName"]?.ToString() ?? "N/A";
                        string email = reader["Email"]?.ToString() ?? "N/A";
                        string gender = reader["Gender"]?.ToString() ?? "N/A";
                        int salary = reader["Salary"] != DBNull.Value ? Convert.ToInt32(reader["Salary"]) : 0;
                        string deptName = reader["DepartmentName"]?.ToString() ?? "N/A";
                        string location = reader["Location"]?.ToString() ?? "N/A";

                        Console.WriteLine($"Name: {empName}, Email: {email}, Gender: {gender}, Salary: {salary}, Department: {deptName}, Location: {location}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        Console.ReadLine();
    }
}
