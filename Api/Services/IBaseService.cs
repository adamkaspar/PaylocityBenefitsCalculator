namespace Api.Services;

public interface IBaseService<T> where T : class
{
    T? Get(int id, CancellationToken cancellationToken = default);

    List<T> GetAll(CancellationToken cancellationToken = default);
}