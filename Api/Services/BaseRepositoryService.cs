using Api.Repositories;
using Mapster;

namespace Api.Services;

public class BaseRepositoryService<T1, T2, T3>(T1 baseRepository) : IBaseRepositoryService<T3>
    where T1 : IBaseRepository<T2>
    where T2 : class
    where T3 : class
{
    protected readonly T1 baseRepository = baseRepository;

    public T3? Get(int id, CancellationToken cancellationToken = default) => baseRepository.Get(id, cancellationToken).Adapt<T3>();

    public List<T3> GetAll(CancellationToken cancellationToken = default) => baseRepository.GetAll(cancellationToken).Adapt<List<T3>>();
}