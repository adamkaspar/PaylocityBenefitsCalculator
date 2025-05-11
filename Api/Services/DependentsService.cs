using Api.Dtos.Dependent;
using Api.Models;
using Api.Repositories;

namespace Api.Services;

public class DependentsService(IDependentsRepository dependentsRepository)
    : BaseRepositoryService<IDependentsRepository, Dependent, GetDependentDto>(dependentsRepository), IDependentsService;