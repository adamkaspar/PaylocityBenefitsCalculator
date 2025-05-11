using Api.Dtos.Dependent;
using Api.Models;
using Api.Repositories;
using AutoMapper;

namespace Api.Services;

public class DependentsService(IDependentsRepository dependentsRepository, IMapper mapper)
    : BaseRepositoryService<IDependentsRepository, Dependent, GetDependentDto>(dependentsRepository, mapper), IDependentsService;