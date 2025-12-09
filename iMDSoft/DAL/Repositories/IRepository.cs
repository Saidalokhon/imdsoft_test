namespace DAL.Repositories
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Update(T entity, int id);
        Task Delete(int id);
    }
}
