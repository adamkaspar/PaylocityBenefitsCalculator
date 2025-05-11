namespace Api.Models;

public class Paycheck : BaseModel
{
    public Employee Employee { get; set; }
    public int Week { get; set; }
    public int Year { get; set; }
    public decimal TotalAmount { get; set; }
}