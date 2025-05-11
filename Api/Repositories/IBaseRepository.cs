namespace Api;

public interface IBaseRepository<T> where T : class
{
    T Get(int id);

    List<T> GetAll();
}