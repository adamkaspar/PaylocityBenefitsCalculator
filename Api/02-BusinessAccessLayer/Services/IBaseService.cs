using Api.BusinessAccessLayer.Dtos;

namespace Api.BusinessAccessLayer.Services;

public interface IBaseService<T> where T : BaseDto
{
    T? GetById(int id);

    Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    List<T> GetAll();

    Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);

    List<T> PageAll(int skip, int take);

    Task<List<T>> PageAllAsync(int skip, int take, CancellationToken cancellationToken);
}