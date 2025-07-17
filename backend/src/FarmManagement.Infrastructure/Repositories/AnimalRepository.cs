using FarmManagement.Domain.Animals.Aggregate;
using FarmManagement.Domain.Animals.ValueObjects;
using FarmManagement.Infrastructure.Persistence;
using FarmManagement.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FarmManagement.Infrastructure.Repositories
{
    public class AnimalRepository : IRepository<Animal, AnimalId>
    {
        private readonly AnimalDbContext _ctx;

        public AnimalRepository(AnimalDbContext ctx) => _ctx = ctx;



        public async Task<Animal?> GetById(AnimalId id) =>
            await _ctx.Animals
                .Include(a => a.HealthRecords)
                .FirstOrDefaultAsync(a => a.Id == id);

        public Task SaveChangesAsync() => _ctx.SaveChangesAsync();
    }
}
