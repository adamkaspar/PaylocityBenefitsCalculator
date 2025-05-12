namespace Api.DataAccessLayer.Models;

public class Employee : BaseModel
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public decimal Salary { get; set; }

    public DateTime DateOfBirth { get; set; }

    public ICollection<Dependent> Dependents { get; set; } = new List<Dependent>();
}
