using Api.Common.Enums;

namespace Api.DataAccessLayer.Models;

public class Dependent : BaseModel
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public Relationship Relationship { get; set; }

    public int EmployeeId { get; set; }

    public Employee? Employee { get; set; }
}
