using Api.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccessLayer.Database;

public class BenefitsDbContext(DbContextOptions<BenefitsDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }

    public DbSet<Dependent> Dependents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>()
            .HasKey(d => d.Id);

        modelBuilder.Entity<Dependent>()
            .HasKey(d => d.Id);

        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Dependents)
            .WithOne()
            .HasForeignKey(d => d.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}