using Api.BusinessAccessLayer.Dtos.Dependent;
using Api.BusinessAccessLayer.Services;
using Api.Common.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.PresentationLayer.Controllers;

public class DependentsController(IDependentsService dependentsService)
    : BaseController<GetDependentDto>(dependentsService)
{
    [SwaggerOperation(Summary = "Get dependent by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetDependentDto>>> Get(int id, CancellationToken cancellationToken = default)
    {
        var dependentDto = await baseService.GetByIdAsync(id, cancellationToken);

        var result = new ApiResponse<GetDependentDto>
        {
            Data = dependentDto,
            Success = dependentDto != null
        };

        return result.Success ? Ok(result) : NotFound(result);
    }

    [SwaggerOperation(Summary = "Get all dependents")]
    [HttpGet("")]
    public async Task<ActionResult<ApiResponse<List<GetDependentDto>>>> GetAll(CancellationToken cancellationToken = default)
    {
        var dependentsDto = await baseService.GetAllAsync(cancellationToken);

        var result = new ApiResponse<List<GetDependentDto>>
        {
            Data = dependentsDto,
            Success = dependentsDto.Count > 0
        };

        return result.Success ? Ok(result) : NotFound(result);
    }
}