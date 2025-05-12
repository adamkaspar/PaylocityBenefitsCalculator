using Api.BusinessAccessLayer.Dtos.Dependent;
using Api.DataAccessLayer.Models;
using Api.DataAccessLayer.Repositories;

namespace Api.BusinessAccessLayer.Services;

public class DependentsService(IDependentsRepository dependentsRepository)
    : BaseRepositoryService<IDependentsRepository, Dependent, GetDependentDto>(dependentsRepository), IDependentsService;