using Api.Models;

namespace Api;

public class Paycheck
{
    public int Id { get; set; }
    public Employee Employee { get; set; }
    public int Week { get; set; }
    public int Year { get; set; }
    public decimal TotalAmount { get; set; }
}