using Api.Dtos.Employee;
using Api.Models;
using Api.Repositories;

namespace Api.Services;

public class EmployeesService(IEmployeesRepository employeesRepository)
    : BaseRepositoryService<IEmployeesRepository, Employee, GetEmployeeDto>(employeesRepository), IEmployeesService;