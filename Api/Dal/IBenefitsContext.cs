using Api.Models;

namespace Api.Dal;

public interface IBenefitsContext
{
    List<Employee> Employees { get; }

    List<Dependent> Dependents { get; }
}