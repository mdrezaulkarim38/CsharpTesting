namespace BasicLearn.Entities;

public class Branch
{
    public int BranchId { get; set; }
    public string? BranchName { get; set; }
    public string? Description { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    
    public ICollection<Student>? Students { get; set; }
}