using Api.Common.Enums;

namespace Api.BusinessAccessLayer.Dtos.Dependent;

public class GetDependentDto : BaseDto
{
    public required string? FirstName { get; init; }

    public required string? LastName { get; init; }

    public required DateTime DateOfBirth { get; init; }

    public required Relationship Relationship { get; init; }
}
