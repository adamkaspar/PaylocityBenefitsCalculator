using Api.Models;

namespace Api;

public interface IBenefitsContext
{
    List<Employee> Employees { get; }

    List<Dependent> Dependents { get; }
}