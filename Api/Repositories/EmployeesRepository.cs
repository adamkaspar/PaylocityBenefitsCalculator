using Api.Dal;
using Api.Models;

namespace Api.Repositories;

public class EmployeesRepository(IBenefitsContext benefitsContext)
    : BaseRepository<Employee>(benefitsContext), IEmployeesRepository
{
    public override Employee? Get(int id, CancellationToken cancellationToken = default) => benefitsContext.Employees.FirstOrDefault(employee => employee.Id == id);

    public override List<Employee> GetAll(CancellationToken cancellationToken = default) => benefitsContext.Employees;
}