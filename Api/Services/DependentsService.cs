using Api.Models;

namespace Api;

public class DependentsService : BaseRepositoryService<IDependentsRepository, Dependent>, IDependentsService
{
    public DependentsService(IDependentsRepository dependentsRepository) : base(dependentsRepository) { }
}