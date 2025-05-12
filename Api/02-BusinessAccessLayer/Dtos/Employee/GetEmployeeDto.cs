using Api.BusinessAccessLayer.Dtos.Dependent;

namespace Api.BusinessAccessLayer.Dtos.Employee;

public class GetEmployeeDto : BaseDto
{
    public required string? FirstName { get; init; }

    public required string? LastName { get; init; }

    public required decimal Salary { get; init; }

    public required DateTime DateOfBirth { get; init; }

    public ICollection<GetDependentDto> Dependents { get; init; } = new List<GetDependentDto>();
}
