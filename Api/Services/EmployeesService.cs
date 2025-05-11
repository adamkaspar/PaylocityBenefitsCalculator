using Api.Models;

namespace Api;

public class EmployeesService : BaseRepositoryService<IEmployeesRepository, Employee>, IEmployeesService
{
    public EmployeesService(IEmployeesRepository employeesRepository) : base(employeesRepository) { }
}