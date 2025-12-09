using AutoMapper;
using BL.Models;
using DAL.Repositories;
using FluentValidation;
using Microsoft.Extensions.Logging;

namespace BL.Services.TestsService
{
    public class TestsService : BaseService<DAL.Entities.Test, Test, TestsService>
    {
        public TestsService(
            IValidator<Test> testValidator,
            IRepository<DAL.Entities.Test> testRepository,
            IMapper mapper,
            ILogger<TestsService> logger)
            : base(testValidator, testRepository, mapper, logger) { }
    }
}
