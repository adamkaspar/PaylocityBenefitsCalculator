namespace Api.Models;

public class Paycheck : BaseModel
{
    public int Week { get; set; }
    public int Year { get; set; }
    public decimal TotalAmount { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}