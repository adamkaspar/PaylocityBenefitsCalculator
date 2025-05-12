using Api.BusinessAccessLayer.Dtos.Employee;
using Api.DataAccessLayer.Models;
using Api.DataAccessLayer.Repositories;

namespace Api.BusinessAccessLayer.Services;

public class EmployeesService(IEmployeesRepository employeesRepository)
    : BaseRepositoryService<IEmployeesRepository, Employee, GetEmployeeDto>(employeesRepository), IEmployeesService;