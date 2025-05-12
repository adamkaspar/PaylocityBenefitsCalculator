using Api.DataAccessLayer.Database;
using Api.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccessLayer.Repositories;

public class BaseRepository<T>(BenefitsDbContext benefitsContext) : IBaseRepository<T>
    where T : BaseModel
{
    protected readonly DbSet<T> set = benefitsContext.Set<T>();

    protected readonly BenefitsDbContext benefitsContext = benefitsContext;

    public virtual T? GetById(int id) => set.Find(id);

    public virtual async Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default) => await set.FindAsync([id], cancellationToken);

    public virtual List<T> GetAll() => set.ToList();

    public virtual async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default) => await set.ToListAsync(cancellationToken);

    public virtual List<T> PageAll(int skip, int take) => set.OrderBy(entity => entity.Id).Skip(skip).Take(take).ToList();

    public virtual async Task<List<T>> PageAllAsync(int skip, int take, CancellationToken cancellationToken) => await set.OrderBy(entity => entity.Id).Skip(skip).Take(take).ToListAsync(cancellationToken);
}