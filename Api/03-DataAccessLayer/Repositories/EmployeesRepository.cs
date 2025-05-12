using Api.DataAccessLayer.Database;
using Api.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccessLayer.Repositories;

public class EmployeesRepository(BenefitsDbContext benefitsContext)
    : BaseRepository<Employee>(benefitsContext), IEmployeesRepository
{
    public override List<Employee> GetAll() => benefitsContext.Employees.Include(employee => employee.Dependents).ToList();

    public override async Task<List<Employee>> GetAllAsync(CancellationToken cancellationToken = default) => await benefitsContext.Employees.Include(employee => employee.Dependents).ToListAsync(cancellationToken);
}