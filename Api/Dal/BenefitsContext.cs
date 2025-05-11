using Api.Enums;
using Api.Models;

namespace Api.Dal;

public class BenefitsContext : IBenefitsContext
{
    public List<Employee> Employees { get; } = new();

    public List<Dependent> Dependents { get; } = new();

    public BenefitsContext()
    {
        SeedData();
    }

    private void SeedData()
    {
        #region Dependents
        Dependents.Add(new()
        {
            Id = 1,
            FirstName = "Spouse",
            LastName = "Morant",
            Relationship = Relationship.Spouse,
            DateOfBirth = new DateTime(1998, 3, 3)
        });

        Dependents.Add(new()
        {
            Id = 2,
            FirstName = "Child1",
            LastName = "Morant",
            Relationship = Relationship.Child,
            DateOfBirth = new DateTime(2020, 6, 23)
        });

        Dependents.Add(new()
        {
            Id = 3,
            FirstName = "Child2",
            LastName = "Morant",
            Relationship = Relationship.Child,
            DateOfBirth = new DateTime(2021, 5, 18)
        });

        Dependents.Add(new()
        {
            Id = 4,
            FirstName = "DP",
            LastName = "Jordan",
            Relationship = Relationship.DomesticPartner,
            DateOfBirth = new DateTime(1974, 1, 2)
        });
        #endregion

        #region Employees
        Employees.Add(new()
        {
            Id = 1,
            FirstName = "LeBron",
            LastName = "James",
            Salary = 75420.99m,
            DateOfBirth = new DateTime(1984, 12, 30)
        });

        Employees.Add(new()
        {
            Id = 2,
            FirstName = "Ja",
            LastName = "Morant",
            Salary = 92365.22m,
            DateOfBirth = new DateTime(1999, 8, 10),
            Dependents = Dependents.Where(dependent => dependent.Id < 4).ToList()
        });

        Employees.Add(new()
        {
            Id = 3,
            FirstName = "Michael",
            LastName = "Jordan",
            Salary = 143211.12m,
            DateOfBirth = new DateTime(1963, 2, 17),
            Dependents = Dependents.Where(dependent => dependent.Id == 4).ToList()
        });
        #endregion
    }
}