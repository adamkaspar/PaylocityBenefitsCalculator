using Api.Dtos.Dependent;
using Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers;

public class DependentsController : BaseController<Dependent>
{
    public DependentsController(IDependentsService dependentsService, IMapper mapper) : base(dependentsService, mapper) { }

    [SwaggerOperation(Summary = "Get dependent by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetDependentDto>>> Get(int id)
    {
        var dependent = BaseService.Get(id);
        var dependentDto = Mapper.Map<GetDependentDto>(dependent);

        var isSuccess = dependent != null;

        var result = new ApiResponse<GetDependentDto>
        {
            Data = dependentDto,
            Success = isSuccess
        };

        return isSuccess ? Ok(result) : NotFound(result);
    }

    [SwaggerOperation(Summary = "Get all dependents")]
    [HttpGet("")]
    public async Task<ActionResult<ApiResponse<List<GetDependentDto>>>> GetAll()
    {
        var dependents = BaseService.GetAll();
        var dependentsDto = Mapper.Map<List<GetDependentDto>>(dependents);

        var isSuccess = dependents != null;

        var result = new ApiResponse<List<GetDependentDto>>
        {
            Data = dependentsDto,
            Success = isSuccess
        };

        return isSuccess ? Ok(result) : NotFound(result);
    }
}