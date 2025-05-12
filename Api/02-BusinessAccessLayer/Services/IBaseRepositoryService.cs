using Api.BusinessAccessLayer.Dtos;

namespace Api.BusinessAccessLayer.Services;

public interface IBaseRepositoryService<T> : IBaseService<T> where T : BaseDto
{

}