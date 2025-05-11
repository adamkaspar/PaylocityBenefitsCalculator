using Api.Dtos.Paycheck;
using Api.Infrastructure;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers;

public class PaychecksController(IPaycheckService paycheckService) : BaseController<GetPaycheckDto>(paycheckService)
{
    [SwaggerOperation(Summary = "Get paycheck by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetPaycheckDto>>> Get(int id, CancellationToken cancellationToken = default)
    {
        var paycheckDto = baseService.Get(id, cancellationToken);

        var result = new ApiResponse<GetPaycheckDto>
        {
            Data = paycheckDto,
            Success = paycheckDto != null
        };

        return result.Success ? Ok(result) : NotFound(result);
    }

    [SwaggerOperation(Summary = "Get all paychecks")]
    [HttpGet("")]
    public async Task<ActionResult<ApiResponse<List<GetPaycheckDto>>>> GetAll(CancellationToken cancellationToken = default)
    {
        var paychecksDto = baseService.GetAll(cancellationToken);

        var result = new ApiResponse<List<GetPaycheckDto>>
        {
            Data = paychecksDto,
            Success = paychecksDto.Count > 0
        };

        return result.Success ? Ok(result) : NotFound(result);
    }

    [SwaggerOperation(Summary = "Get paychecks by employee id")]
    [HttpGet("GetByEmployeeId/{id}")]
    public async Task<ActionResult<ApiResponse<List<GetPaycheckDto>>>> GetByEmployeeId(int id, CancellationToken cancellationToken = default)
    {
        var paychecksDto = ((IPaycheckService)baseService).GetByEmployeeId(id, cancellationToken);

        var result = new ApiResponse<List<GetPaycheckDto>>
        {
            Data = paychecksDto,
            Success = paychecksDto.Count > 0
        };

        return result.Success ? Ok(result) : NotFound(result);
    }
}