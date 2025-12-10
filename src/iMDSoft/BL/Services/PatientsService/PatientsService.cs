using AutoMapper;
using DAL.Repositories;
using FluentValidation;
using Microsoft.Extensions.Logging;

namespace BL.Services.PatientsService
{
    public class PatientsService : BaseService<DAL.Entities.Patient, BL.Models.Patient, PatientsService>
    {
        public PatientsService(
            IValidator<BL.Models.Patient> patientValidator,
            IRepository<DAL.Entities.Patient> patientRepository,
            IMapper mapper,
            ILogger<PatientsService> logger)
            : base(patientValidator, patientRepository, mapper, logger)
        {
        }
    }
}
