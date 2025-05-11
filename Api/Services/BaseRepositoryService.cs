using Api.Repositories;
using AutoMapper;

namespace Api.Services;

public class BaseRepositoryService<T1, T2, T3>(T1 baseRepository, IMapper mapper) : IBaseRepositoryService<T3>
    where T1 : IBaseRepository<T2>
    where T2 : class
    where T3 : class
{
    protected T1 baseRepository = baseRepository;

    protected IMapper mapper = mapper;

    public T3? Get(int id, CancellationToken cancellationToken = default) => mapper.Map<T3>(baseRepository.Get(id, cancellationToken)) ;

    public List<T3> GetAll(CancellationToken cancellationToken = default) => mapper.Map<List<T3>>(baseRepository.GetAll(cancellationToken));
}