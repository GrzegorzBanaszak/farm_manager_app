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


        public async Task<IEnumerable<Animal>> GetAll()
        {
            return await _ctx.Animals
                                 .Include(a => a.HealthRecords)
                                 .ToListAsync();
        }

        public async Task<Animal?> GetById(AnimalId id) =>
            await _ctx.Animals
                .Include(a => a.HealthRecords)
                .FirstOrDefaultAsync(a => a.Id == id);


        public async Task Add(Animal entity)
        {
            await _ctx.Animals.AddAsync(entity);
        }

        public Task Update(Animal entity)
        {
            _ctx.Animals.Update(entity);
            return Task.CompletedTask;
        }

        public async Task Delete(AnimalId id)
        {
            var entity = await _ctx.Animals.FindAsync(id);
            if (entity != null)
                _ctx.Animals.Remove(entity);
        }



        public Task SaveChangesAsync() => _ctx.SaveChangesAsync();


    }
}
