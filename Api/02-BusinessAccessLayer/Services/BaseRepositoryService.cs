using Api.BusinessAccessLayer.Dtos;
using Api.DataAccessLayer.Models;
using Api.DataAccessLayer.Repositories;
using Mapster;

namespace Api.BusinessAccessLayer.Services;

public class BaseRepositoryService<T1, T2, T3>(T1 baseRepository) : IBaseRepositoryService<T3>
    where T1 : IBaseRepository<T2>
    where T2 : BaseModel
    where T3 : BaseDto
{
    protected readonly T1 baseRepository = baseRepository;

    public T3? GetById(int id) => baseRepository.GetById(id).Adapt<T3>();

    public async Task<T3?> GetByIdAsync(int id, CancellationToken cancellationToken) => (await baseRepository.GetByIdAsync(id, cancellationToken)).Adapt<T3>();

    public List<T3> GetAll() => baseRepository.GetAll().Adapt<List<T3>>();

    public async Task<List<T3>> GetAllAsync(CancellationToken cancellationToken = default) => (await baseRepository.GetAllAsync(cancellationToken)).Adapt<List<T3>>();

    public List<T3> PageAll(int skip, int take) => baseRepository.PageAll(skip, take).Adapt<List<T3>>();

    public async Task<List<T3>> PageAllAsync(int skip, int take, CancellationToken cancellationToken) => (await baseRepository.PageAllAsync(skip, take, cancellationToken)).Adapt<List<T3>>();
}