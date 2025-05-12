using Api.DataAccessLayer.Database;
using Api.DataAccessLayer.Models;

namespace Api.DataAccessLayer.Repositories;

public class DependentsRepository(BenefitsDbContext benefitsContext)
    : BaseRepository<Dependent>(benefitsContext), IDependentsRepository
{
}