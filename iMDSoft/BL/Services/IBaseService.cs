namespace BL.Services
{
    public interface IBaseService<TEntity, TModel, TLoggingScope>
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(int id);
        Task AddAsync(TModel model);
        Task DeleteAsync(int id);
        Task UpdateAsync(TModel model, int id);
        Task<FluentValidation.Results.ValidationResult> ValidateAsync(TModel model);
    }
}
