using AutoMapper;
using DAL.Repositories;
using FluentValidation;
using Microsoft.Extensions.Logging;

namespace BL.Services
{
    public abstract class BaseService<TEntity, TModel, TLoggingScope> : IBaseService<TEntity, TModel, TLoggingScope>
    {
        private readonly IValidator<TModel> _validator;
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<TLoggingScope> _logger;

        public BaseService(
            IValidator<TModel> validator,
            IRepository<TEntity> repository,
            IMapper mapper,
            ILogger<TLoggingScope> logger)
        {
            _validator = validator;
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task AddAsync(TModel model)
        {
            try
            {
                _logger.LogInformation("Adding new entity of type {EntityType}.", typeof(TEntity).Name);
                await _repository.AddAsync(_mapper.Map<TEntity>(model));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a new entity.");
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                _logger.LogInformation("Deleting entity of type {EntityType} with ID {Id}.", typeof(TEntity).Name, id);
                await _repository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting an entity with ID {Id}.", id);
                throw;
            }
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            try
            {
                _logger.LogInformation("Retrieving all entities of type {EntityType}.", typeof(TEntity).Name);
                return _mapper.Map<IEnumerable<TModel>>(await _repository.GetAllAsync());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving all entities.");
                throw;
            }
        }

        public async Task<TModel> GetByIdAsync(int id)
        {
            try
            {
                _logger.LogInformation("Retrieving entity of type {EntityType} with ID {Id}.", typeof(TEntity).Name, id);
                return _mapper.Map<TModel>(await _repository.GetByIdAsync(id));

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving an entity with ID {Id}.", id);
                throw;
            }
        }

        public async Task UpdateAsync(TModel model, int id)
        {
            try
            {
                _logger.LogInformation("Updating entity of type {EntityType}.", typeof(TEntity).Name);
                await _repository.UpdateAsync(_mapper.Map<TEntity>(model), id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating an entity.");
                throw;
            }
        }

        public async Task<FluentValidation.Results.ValidationResult> ValidateAsync(TModel model)
        {
            _logger.LogInformation("Validating model of type {ModelType}.", typeof(TModel).Name);
            return await _validator.ValidateAsync(model);
        }
    }
}
