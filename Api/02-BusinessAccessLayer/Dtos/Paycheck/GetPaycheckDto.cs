namespace Api.BusinessAccessLayer.Dtos.Paycheck;

public class GetPaycheckDto : BaseDto
{
    public required string EmployeeFirstName { get; init; }

    public required string EmployeeLastName { get; init; }

    public required int Week { get; init; }

    public required int Year { get; init; }

    public required decimal TotalAmount { get; init; }
}