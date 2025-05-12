using Api.BusinessAccessLayer.Calculators;
using Api.BusinessAccessLayer.Dtos.Paycheck;
using Api.DataAccessLayer.Repositories;
using Mapster;

namespace Api.BusinessAccessLayer.Services;

public class PaycheckService(IEmployeesRepository employeesRepository, IPaycheckCalculator paycheckCalculator) : IPaycheckService
{
    protected readonly IEmployeesRepository employeesRepository = employeesRepository;

    protected readonly IPaycheckCalculator paycheckCalculator = paycheckCalculator;

    public GetPaycheckDto? GetById(int id)
    {
        var paychecks = GetAll();
        var result = paychecks.FirstOrDefault(paycheck => paycheck.Id == id);

        return result;
    }

    public async Task<GetPaycheckDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var paychecks = await GetAllAsync(cancellationToken);
        var result = paychecks.FirstOrDefault(paycheck => paycheck.Id == id);

        return result;
    }

    public List<GetPaycheckDto> GetAll()
    {
        var employees = employeesRepository.GetAll();
        var result = new List<GetPaycheckDto>();

        employees.ForEach(employee => result.AddRange(paycheckCalculator.ComputePaychecks(employee).Adapt<List<GetPaycheckDto>>()));

        return result;
    }

    public async Task<List<GetPaycheckDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var employees = await employeesRepository.GetAllAsync(cancellationToken);
        var result = new List<GetPaycheckDto>();

        employees.ForEach(employee => result.AddRange(paycheckCalculator.ComputePaychecks(employee).Adapt<List<GetPaycheckDto>>()));

        return result;
    }

    public List<GetPaycheckDto> GetByEmployeeId(int id)
    {
        var employee = employeesRepository.GetById(id);
        var result = new List<GetPaycheckDto>();

        if (employee != null)
        {
            result.AddRange(paycheckCalculator.ComputePaychecks(employee).Adapt<List<GetPaycheckDto>>());
        }

        return result;
    }

    public async Task<List<GetPaycheckDto>> GetByEmployeeIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var employee = await employeesRepository.GetByIdAsync(id, cancellationToken);
        var result = new List<GetPaycheckDto>();

        if (employee != null)
        {
            result.AddRange(paycheckCalculator.ComputePaychecks(employee).Adapt<List<GetPaycheckDto>>());
        }

        return result;
    }

    public List<GetPaycheckDto> PageAll(int skip, int take)
    {
        var employees = employeesRepository.PageAll(skip, take);
        var result = new List<GetPaycheckDto>();

        employees.ForEach(employee => result.AddRange(paycheckCalculator.ComputePaychecks(employee).Adapt<List<GetPaycheckDto>>()));

        return result;
    }

    public async Task<List<GetPaycheckDto>> PageAllAsync(int skip, int take, CancellationToken cancellationToken)
    {
        var employees = await employeesRepository.PageAllAsync(skip, take, cancellationToken);
        var result = new List<GetPaycheckDto>();

        employees.ForEach(employee => result.AddRange(paycheckCalculator.ComputePaychecks(employee).Adapt<List<GetPaycheckDto>>()));

        return result;
    }
}