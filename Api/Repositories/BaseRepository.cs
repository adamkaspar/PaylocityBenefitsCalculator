namespace Api;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected IBenefitsContext BenefitsContext { get; private set; }

    public BaseRepository(IBenefitsContext benefitsContext)
    {
        BenefitsContext = benefitsContext;
    }

    public virtual T Get(int id)
    {
        //Here should be Get from specific DbSet, based on generic type, but in this example I dont work with DbSets, 
        //so I keep it umimplemented with concrete implementation in derived types.
        throw new NotImplementedException();
    }

    public virtual List<T> GetAll()
    {
        //Here should be GetAll from specific DbSet, based on generic type, but in this example I dont work with DbSets, 
        //so I keep it umimplemented with concrete implementation in derived types.
        throw new NotImplementedException();
    }
}