namespace BL.Services
{
    public interface IBaseService<TEntity, TModel, TLoggingScope>
    {
        Task<IEnumerable<TModel>> GetAll();
        Task<TModel> GetById(int id);
        Task Add(TModel model);
        Task Delete(int id);
        Task Update(TModel model, int id);
        Task<FluentValidation.Results.ValidationResult> Validate(TModel model);
    }
}
