using Api.BusinessAccessLayer.Dtos.Paycheck;
using Api.BusinessAccessLayer.Services;
using Api.Common.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.PresentationLayer.Controllers;

public class PaychecksController(IPaycheckService paycheckService) : BaseController<GetPaycheckDto>(paycheckService)
{
    [SwaggerOperation(Summary = "Get paycheck by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetPaycheckDto>>> Get(int id, CancellationToken cancellationToken = default)
    {
        var paycheckDto = await baseService.GetByIdAsync(id, cancellationToken);

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
        var paychecksDto = await baseService.GetAllAsync(cancellationToken);

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
        var paychecksDto = await ((IPaycheckService)baseService).GetByEmployeeIdAsync(id, cancellationToken);

        var result = new ApiResponse<List<GetPaycheckDto>>
        {
            Data = paychecksDto,
            Success = paychecksDto.Count > 0
        };

        return result.Success ? Ok(result) : NotFound(result);
    }
}