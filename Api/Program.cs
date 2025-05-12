using Api.Common.Infrastructure;
using Api.DataAccessLayer.Database;
using Api.PresentationLayer.Controllers;
using Api.PresentationLayer.Middleware;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Employee Benefit Cost Calculation Api",
        Description = "Api to support employee benefit cost calculations"
    });
});

var allowLocalhost = "allow localhost";
builder.Services.AddCors(options =>
{
    options.AddPolicy(allowLocalhost,
        policy => { policy.WithOrigins("http://localhost:3000", "http://localhost"); });
});

//Register all types as implemented Interfaces using Scrutor library
builder.Services.Scan(scan => scan
    .FromAssemblyOf<DependentsController>()
    .AddClasses()
    .AsImplementedInterfaces()
    .WithScopedLifetime());

//Register configuration settings
builder.Services.Configure<PaycheckSettings>(builder.Configuration.GetSection("PaycheckSettings"));

//Register DbContext with In-Memory database
builder.Services.AddDbContext<BenefitsDbContext>(options => options.UseInMemoryDatabase("BenefitsDb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(allowLocalhost);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Initialize the database with sample data
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

var context = services.GetRequiredService<BenefitsDbContext>();
context.Database.EnsureCreated();
BenefitsDbInitializer.Initialize(context);

// Register middleware for error handling
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.Run();