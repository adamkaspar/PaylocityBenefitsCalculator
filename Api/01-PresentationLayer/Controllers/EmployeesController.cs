using Api.BusinessAccessLayer.Dtos.Employee;
using Api.BusinessAccessLayer.Services;
using Api.Common.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.PresentationLayer.Controllers;

public class EmployeesController(IEmployeesService employeesService)
    : BaseController<GetEmployeeDto>(employeesService)
{
    [SwaggerOperation(Summary = "Get employee by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetEmployeeDto>>> Get(int id, CancellationToken cancellationToken = default)
    {
        var employeeDto = await baseService.GetByIdAsync(id, cancellationToken);

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
        var employeesDto = await baseService.GetAllAsync(cancellationToken);

        var result = new ApiResponse<List<GetEmployeeDto>>
        {
            Data = employeesDto,
            Success = employeesDto.Count > 0
        };

        return result.Success ? Ok(result) : NotFound(result);
    }
}