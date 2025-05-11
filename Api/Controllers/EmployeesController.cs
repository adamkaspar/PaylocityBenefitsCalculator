using Api.Dtos.Employee;
using Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers;

public class EmployeesController : BaseController<Employee>
{
    public EmployeesController(IEmployeesService employeesService, IMapper mapper) : base(employeesService, mapper) { }

    [SwaggerOperation(Summary = "Get employee by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetEmployeeDto>>> Get(int id)
    {
        var employee = BaseService.Get(id);
        var employeeDto = Mapper.Map<GetEmployeeDto>(employee);

        var isSuccess = employee != null;

        var result = new ApiResponse<GetEmployeeDto>
        {
            Data = employeeDto,
            Success = isSuccess
        };

        return isSuccess ? Ok(result) : NotFound(result);
    }

    [SwaggerOperation(Summary = "Get all employees")]
    [HttpGet("")]
    public async Task<ActionResult<ApiResponse<List<GetEmployeeDto>>>> GetAll()
    {
        //task: use a more realistic production approach
        var employees = BaseService.GetAll();
        var employeesDto = Mapper.Map<List<GetEmployeeDto>>(employees);

        var isSuccess = employees != null;

        var result = new ApiResponse<List<GetEmployeeDto>>
        {
            Data = employeesDto,
            Success = isSuccess
        };

        return isSuccess ? Ok(result) : NotFound(result);
    }
}