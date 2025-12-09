using AutoMapper;

namespace BL.Mappings
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<DAL.Entities.Patient, Models.Patient>()
                .ReverseMap();
        }
    }
}
