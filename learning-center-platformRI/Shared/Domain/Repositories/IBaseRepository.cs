namespace learning_center_platformRI.Shared.Domain.Repositories;

public interface IBaseRepository<TEntity>
{
    Task AddASync(TEntity entity);
    Task<TEntity?> FindByIdAsync(int id);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    Task<IEnumerable<TEntity>> ListAsync();

}