using Api.BusinessAccessLayer.Dtos;
using Api.BusinessAccessLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.PresentationLayer.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BaseController<T>(IBaseService<T> baseService) : ControllerBase
    where T : BaseDto
{
    protected readonly IBaseService<T> baseService = baseService;
}