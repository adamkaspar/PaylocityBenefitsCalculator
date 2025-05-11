namespace Api;

public interface IBaseService<T> where T : class
{
    T Get(int id);

    List<T> GetAll();
}