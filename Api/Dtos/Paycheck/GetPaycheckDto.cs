namespace Api.Dtos.Paycheck;

public class GetPaycheckDto : BaseDto
{
    public string EmployeeFirstName { get; set; }
    public string EmployeeLastName { get; set; }
    public int Week { get; set; }
    public int Year { get; set; }
    public decimal TotalAmount { get; set; }
}