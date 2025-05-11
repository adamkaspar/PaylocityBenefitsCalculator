using Api.Dtos.Employee;

namespace Api;

public class GetPaycheckDto
{
    public int Id { get; set; }
    public string EmployeeFirstName { get; set; }
    public string EmployeeLastName { get; set; }
    public int Week { get; set; }
    public int Year { get; set; }
    public decimal TotalAmount { get; set; }
}