using Api.DataAccess;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories;

public class EmployeesRepository(IBenefitsDbContext benefitsContext)
    : BaseRepository<Employee>(benefitsContext), IEmployeesRepository
{
    public override Employee? Get(int id, CancellationToken cancellationToken = default) => benefitsContext.Employees.FirstOrDefault(employee => employee.Id == id);

    public override List<Employee> GetAll(CancellationToken cancellationToken = default) => benefitsContext.Employees.Include(employee => employee.Dependents).ToList();
}