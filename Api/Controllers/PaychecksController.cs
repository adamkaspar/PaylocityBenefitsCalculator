using Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api;

public class PaychecksController : BaseController<Paycheck>
{
    public PaychecksController(IPaycheckService paycheckService, IMapper mapper) : base(paycheckService, mapper) { }

    [SwaggerOperation(Summary = "Get paycheck by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetPaycheckDto>>> Get(int id)
    {
        var paycheck = BaseService.Get(id);
        var paycheckDto = Mapper.Map<GetPaycheckDto>(paycheck);

        var isSuccess = paycheck != null;

        var result = new ApiResponse<GetPaycheckDto>
        {
            Data = paycheckDto,
            Success = isSuccess
        };

        return isSuccess ? Ok(result) : NotFound(result);
    }

    [SwaggerOperation(Summary = "Get all paychecks")]
    [HttpGet("")]
    public async Task<ActionResult<ApiResponse<List<GetPaycheckDto>>>> GetAll()
    {
        var paychecks = BaseService.GetAll();
        var paychecksDto = Mapper.Map<List<GetPaycheckDto>>(paychecks);

        var isSuccess = paychecks != null;

        var result = new ApiResponse<List<GetPaycheckDto>>
        {
            Data = paychecksDto,
            Success = isSuccess
        };

        return isSuccess ? Ok(result) : NotFound(result);
    }

    [SwaggerOperation(Summary = "Get paychecks by employee id")]
    [HttpGet("GetByEmployeeId/{id}")]
    public async Task<ActionResult<ApiResponse<List<GetPaycheckDto>>>> GetByEmployeeId(int id)
    {
        var paychecks = ((IPaycheckService)BaseService).GetByEmployeeId(id);
        var paychecksDto = Mapper.Map<List<GetPaycheckDto>>(paychecks);

        var isSuccess = paychecks != null;

        var result = new ApiResponse<List<GetPaycheckDto>>
        {
            Data = paychecksDto,
            Success = isSuccess
        };

        return isSuccess ? Ok(result) : NotFound(result);
    }
}