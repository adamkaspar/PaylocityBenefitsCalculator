using Api.DataAccess;

namespace Api.Repositories;

public class BaseRepository<T>(IBenefitsDbContext benefitsContext) : IBaseRepository<T>
    where T : class
{
    protected readonly IBenefitsDbContext benefitsContext = benefitsContext;

    public virtual T? Get(int id, CancellationToken cancellationToken = default)
    {
        //Here should be Get from specific DbSet, based on generic type, but in this example I dont work with DbSets, 
        //so I keep it umimplemented with concrete implementation in derived types.
        throw new NotImplementedException();
    }

    public virtual List<T> GetAll(CancellationToken cancellationToken = default)
    {
        //Here should be GetAll from specific DbSet, based on generic type, but in this example I dont work with DbSets, 
        //so I keep it umimplemented with concrete implementation in derived types.
        throw new NotImplementedException();
    }
}