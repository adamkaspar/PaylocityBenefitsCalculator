using Api.BusinessAccessLayer.Dtos.Paycheck;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ApiTests.IntegrationTests;

public class PaycheckIntegrationTests : IntegrationTest
{
    [Fact]
    public async Task WhenAskedForAllPaychecks_ShouldReturnAllPaychecks()
    {
        var response = await HttpClient.GetAsync("/api/v1/paychecks");
        var paychecks = new List<GetPaycheckDto>{
        new() {
            Id =  1002,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 2,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1004,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 4,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1006,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 6,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1008,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 8,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1010,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 10,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1012,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 12,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1014,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 14,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1016,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 16,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1018,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 18,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1020,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 20,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1022,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 22,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1024,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 24,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1026,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 26,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1028,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 28,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1030,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 30,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1032,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 32,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1034,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 34,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1036,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 36,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1038,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 38,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1040,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 40,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1042,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 42,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1044,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 44,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1046,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 46,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1048,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 48,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1050,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 50,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  1052,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName =  "James",
            Week = 52,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id =  2002,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 2,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2004,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 4,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2006,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 6,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2008,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 8,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2010,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 10,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2012,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 12,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2014,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 14,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2016,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 16,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2018,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 18,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2020,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 20,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2022,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 22,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2024,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 24,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2026,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 26,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2028,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 28,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2030,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 30,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2032,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 32,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2034,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 34,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2036,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 36,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2038,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 38,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2040,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 40,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2042,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 42,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2044,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 44,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2046,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 46,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2048,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 48,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2050,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 50,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  2052,
            EmployeeFirstName =  "Ja",
            EmployeeLastName =  "Morant",
            Week = 52,
            Year =  DateTime.Now.Year,
            TotalAmount =  2189.1506m
        },
        new() {
            Id =  3002,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 2,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3004,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 4,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3006,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 6,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3008,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 8,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3010,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 10,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3012,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 12,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3014,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 14,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3016,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 16,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3018,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 18,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3020,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 20,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3022,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 22,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3024,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 24,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3026,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 26,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3028,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 28,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3030,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 30,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3032,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 32,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3034,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 34,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3036,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 36,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3038,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 38,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3040,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 40,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3042,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 42,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3044,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 44,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3046,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 46,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3048,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 48,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3050,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 50,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        },
        new() {
            Id =  3052,
            EmployeeFirstName =  "Michael",
            EmployeeLastName =  "Jordan",
            Week = 52,
            Year =  DateTime.Now.Year,
            TotalAmount =  4567.1883692307692307692307692m
        }
        };

        await response.ShouldReturn(HttpStatusCode.OK, paychecks);
    }

    [Fact]
    public async Task WhenAskedForAnPaycheck_ShouldReturnCorrectPaycheck()
    {
        var response = await HttpClient.GetAsync("/api/v1/paychecks/1002");
        var paycheck = new GetPaycheckDto
        {
            Id = 1002,
            EmployeeFirstName = "LeBron",
            EmployeeLastName = "James",
            Week = 2,
            Year = DateTime.Now.Year,
            TotalAmount = 2381.2527m
        };
        await response.ShouldReturn(HttpStatusCode.OK, paycheck);
    }

    [Fact]
    public async Task WhenAskedForANonexistentPaycheck_ShouldReturn404()
    {
        var response = await HttpClient.GetAsync($"/api/v1/paychecks/{int.MinValue}");
        await response.ShouldReturn(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task WhenAskedForAPaychecksForSpecificEmployee_ShouldReturnCorrectPaycheck()
    {
        var response = await HttpClient.GetAsync("/api/v1/paychecks/getbyemployeeid/1");
        var paychecks = new List<GetPaycheckDto>
        {
        new() {
            Id = 1002,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 2,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1004,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 4,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1006,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 6,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1008,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 8,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1010,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 10,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1012,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 12,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1014,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 14,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1016,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 16,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1018,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 18,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1020,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 20,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1022,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 22,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1024,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 24,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1026,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 26,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1028,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 28,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1030,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 30,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1032,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 32,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1034,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 34,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1036,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 36,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1038,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 38,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1040,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 40,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1042,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 42,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1044,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 44,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1046,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 46,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1048,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 48,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1050,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 50,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        },
        new() {
            Id = 1052,
            EmployeeFirstName =  "LeBron",
            EmployeeLastName = "James",
            Week = 52,
            Year =  DateTime.Now.Year,
            TotalAmount =  2381.2527m
        }
        };
        await response.ShouldReturn(HttpStatusCode.OK, paychecks);
    }

    [Fact]
    public async Task WhenAskedForAPaychecksForNonexistentEmployee_ShouldReturn404()
    {
        var response = await HttpClient.GetAsync("/api/v1/paychecks/getbyemployeeid/4");
        await response.ShouldReturn(HttpStatusCode.NotFound);
    }
}