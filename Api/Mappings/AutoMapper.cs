using Api.Dtos.Dependent;
using Api.Dtos.Employee;
using Api.Dtos.Paycheck;
using Api.Models;
using AutoMapper;

namespace Api.Mappings;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<Employee, GetEmployeeDto>();
        CreateMap<Dependent, GetDependentDto>();
        CreateMap<Paycheck, GetPaycheckDto>();
    }
}