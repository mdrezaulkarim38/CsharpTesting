using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace api.Data;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        // Suppress warnings about pending model changes (use only for debugging purposes)
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Seed roles
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "User", NormalizedName = "USER" }
        );

        // Seed Stocks
        builder.Entity<Stock>().HasData(
            new Stock
            {
                Id = 1,
                Symbol = "AAPL",
                CompanyName = "Apple Inc.",
                Purchase = 145.32m,
                LastDiv = 0.22m,
                Industry = "Technology",
                MarketCap = 2300000000000
            },
            new Stock
            {
                Id = 2,
                Symbol = "TSLA",
                CompanyName = "Tesla Inc.",
                Purchase = 255.78m,
                LastDiv = 0.00m,
                Industry = "Automotive",
                MarketCap = 900000000000
            }
        );

        // Seed Comments
        builder.Entity<Comment>().HasData(
            new Comment
            {
                Id = 1,
                Title = "Strong Q3 Performance",
                Content = "Apple reported excellent Q3 earnings with a growth in services revenue.",
                CreatedOn = DateTime.Now.AddDays(-10),
                StockId = 1
            },
            new Comment
            {
                Id = 2,
                Title = "Exciting Model S Updates",
                Content = "Tesla unveiled exciting updates to the Model S lineup, boosting investor confidence.",
                CreatedOn = DateTime.Now.AddDays(-5),
                StockId = 2
            }
        );
    }
}
