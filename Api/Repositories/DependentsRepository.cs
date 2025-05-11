using Api.Models;

namespace Api;

public class DependentsRepository : BaseRepository<Dependent>, IDependentsRepository
{
    public DependentsRepository(IBenefitsContext benefitsContext) : base(benefitsContext) { }

    public override Dependent Get(int id) => BenefitsContext.Dependents.FirstOrDefault(employee => employee.Id == id);

    public override List<Dependent> GetAll() => BenefitsContext.Dependents;
}