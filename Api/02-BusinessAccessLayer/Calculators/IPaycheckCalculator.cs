using Api.BusinessAccessLayer.Dtos.Paycheck;
using Api.DataAccessLayer.Models;

namespace Api.BusinessAccessLayer.Calculators;

public interface IPaycheckCalculator
{
    List<GetPaycheckDto> ComputePaychecks(Employee employee);
}