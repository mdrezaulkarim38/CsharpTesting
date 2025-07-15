using BasicLearn.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasicLearn.Data;

public class EfCoreDbContext : DbContext
{
    public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options) : base(options)
    {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=local,1433;Database=TestingDB;User Id=sa;Password=Shuvo123;");
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Branch> Branches { get; set; }
}