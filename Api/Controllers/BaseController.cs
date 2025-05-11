using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BaseController<T>(IBaseService<T> baseService) : ControllerBase
    where T : class
{
    protected IBaseService<T> baseService = baseService;
}