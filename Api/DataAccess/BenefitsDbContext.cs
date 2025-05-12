using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess;

public class BenefitsDbContext(DbContextOptions<BenefitsDbContext> options) : DbContext(options), IBenefitsDbContext
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
        modelBuilder.Entity<Paycheck>()
            .HasKey(d => d.Id);

        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Dependents)
            .WithOne()
            .HasForeignKey(d => d.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Paychecks)
            .WithOne()
            .HasForeignKey(d => d.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
    }


}