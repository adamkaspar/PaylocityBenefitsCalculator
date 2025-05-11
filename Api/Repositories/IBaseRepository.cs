namespace Api.Repositories;

public interface IBaseRepository<T> where T : class
{
    T? Get(int id, CancellationToken cancellationToken = default);

    List<T> GetAll(CancellationToken cancellationToken = default);
}