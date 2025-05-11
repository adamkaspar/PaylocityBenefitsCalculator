using Api.Dtos.Paycheck;

namespace Api.Services;

public interface IPaycheckService : IBaseService<GetPaycheckDto>
{
    List<GetPaycheckDto> GetByEmployeeId(int id, CancellationToken cancellationToken = default);
}