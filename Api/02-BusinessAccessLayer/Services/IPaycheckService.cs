using Api.BusinessAccessLayer.Dtos.Paycheck;

namespace Api.BusinessAccessLayer.Services;

public interface IPaycheckService : IBaseService<GetPaycheckDto>
{
    List<GetPaycheckDto> GetByEmployeeId(int id);

    Task<List<GetPaycheckDto>> GetByEmployeeIdAsync(int id, CancellationToken cancellationToken = default);
}