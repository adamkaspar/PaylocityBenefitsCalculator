using Api.Dtos.Employee;
using Api.Infrastructure;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers;

public class EmployeesController(IEmployeesService employeesService)
    : BaseController<GetEmployeeDto>(employeesService)
{
    [SwaggerOperation(Summary = "Get employee by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetEmployeeDto>>> Get(int id, CancellationToken cancellationToken = default)
    {
        var employeeDto = baseService.Get(id, cancellationToken);

        var result = new ApiResponse<GetEmployeeDto>
        {
            Data = employeeDto,
            Success = employeeDto != null
        };

        return result.Success ? Ok(result) : NotFound(result);
    }

    [SwaggerOperation(Summary = "Get all employees")]
    [HttpGet("")]
    public async Task<ActionResult<ApiResponse<List<GetEmployeeDto>>>> GetAll(CancellationToken cancellationToken = default)
    {
        //task: use a more realistic production approach
        var employeesDto = baseService.GetAll(cancellationToken);

        var result = new ApiResponse<List<GetEmployeeDto>>
        {
            Data = employeesDto,
            Success = employeesDto.Count > 0
        };

        return result.Success ? Ok(result) : NotFound(result);
    }
}