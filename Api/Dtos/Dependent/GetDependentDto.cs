using Api.Enums;

namespace Api.Dtos.Dependent;

public class GetDependentDto : BaseDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Relationship Relationship { get; set; }
}
