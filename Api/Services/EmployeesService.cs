using Api.Dtos.Employee;
using Api.Models;
using Api.Repositories;
using AutoMapper;

namespace Api.Services;

public class EmployeesService(IEmployeesRepository employeesRepository, IMapper mapper)
    : BaseRepositoryService<IEmployeesRepository, Employee, GetEmployeeDto>(employeesRepository, mapper), IEmployeesService;