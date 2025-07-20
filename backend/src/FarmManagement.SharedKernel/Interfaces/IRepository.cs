namespace FarmManagement.SharedKernel.Interfaces
{
    public interface IRepository<TEntity, TId> where TEntity : class
    {
        Task<TEntity?> GetById(TId id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TId id);
        Task<IEnumerable<TEntity>> GetAll();
        Task SaveChangesAsync();
    }

}
