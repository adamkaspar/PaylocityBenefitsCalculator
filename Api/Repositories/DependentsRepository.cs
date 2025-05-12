using Api.DataAccess;
using Api.Models;

namespace Api.Repositories;

public class DependentsRepository(IBenefitsDbContext benefitsContext)
    : BaseRepository<Dependent>(benefitsContext), IDependentsRepository
{
    public override Dependent? Get(int id, CancellationToken cancellationToken = default) => benefitsContext.Dependents.FirstOrDefault(employee => employee.Id == id);

    public override List<Dependent> GetAll(CancellationToken cancellationToken = default) => benefitsContext.Dependents.ToList();
}