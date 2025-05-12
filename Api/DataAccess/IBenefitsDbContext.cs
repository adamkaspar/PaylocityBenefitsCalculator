using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess;

public interface IBenefitsDbContext
{
    DbSet<Employee> Employees { get; }

    DbSet<Dependent> Dependents { get; }
}