namespace Api;

public interface IPaycheckService : IBaseService<Paycheck>
{
    List<Paycheck> GetByEmployeeId(int id);
}