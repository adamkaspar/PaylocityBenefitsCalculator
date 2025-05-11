using Api.Dtos.Dependent;
using Api.Dtos.Employee;
using Api.Models;
using AutoMapper;

namespace Api;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<Employee, GetEmployeeDto>();
        CreateMap<Dependent, GetDependentDto>();
        CreateMap<Paycheck, GetPaycheckDto>();
    }
}