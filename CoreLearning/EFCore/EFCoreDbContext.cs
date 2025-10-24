using CoreLearning.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreLearning.EFCore;

public class EFCoreDbContext : DbContext
{
    public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=SHUVO\\SQLEXPRESS;Database=LearningEFCore;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Branch> Branches { get; set; }
}