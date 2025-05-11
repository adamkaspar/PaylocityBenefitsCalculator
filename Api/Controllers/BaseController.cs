using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Api;

[ApiController]
[Route("api/v1/[controller]")]
public class BaseController<T> : ControllerBase where T : class
{
    protected IBaseService<T> BaseService { get; }

    protected IMapper Mapper { get; }

    public BaseController(IBaseService<T> baseService, IMapper mapper)
    {
        BaseService = baseService;
        Mapper = mapper;
    }
}