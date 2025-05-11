namespace Api;

public class BaseRepositoryService<T1, T2> : IBaseRepositoryService<T2> where T1 : IBaseRepository<T2> where T2 : class
{
    protected T1 BaseRepository { get; }

    public BaseRepositoryService(T1 baseRepository)
    {
        BaseRepository = baseRepository;
    }

    public T2 Get(int id) => BaseRepository.Get(id);

    public List<T2> GetAll() => BaseRepository.GetAll();
}