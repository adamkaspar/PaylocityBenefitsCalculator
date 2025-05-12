using Api.DataAccessLayer.Models;

namespace Api.DataAccessLayer.Repositories;

public interface IBaseRepository<T> where T : BaseModel
{
    T? GetById(int id);

    Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    List<T> GetAll();

    Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);

    List<T> PageAll(int skip, int take);

    Task<List<T>> PageAllAsync(int skip, int take, CancellationToken cancellationToken);
}