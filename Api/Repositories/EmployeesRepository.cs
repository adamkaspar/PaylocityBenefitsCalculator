using Api.Models;

namespace Api;

public class EmployeesRepository : BaseRepository<Employee>, IEmployeesRepository
{
    public EmployeesRepository(IBenefitsContext benefitsContext) : base(benefitsContext) { }

    public override Employee Get(int id) => BenefitsContext.Employees.FirstOrDefault(employee => employee.Id == id);

    public override List<Employee> GetAll() => BenefitsContext.Employees;
}