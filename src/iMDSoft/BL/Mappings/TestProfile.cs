using AutoMapper;

namespace BL.Mappings
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<DAL.Entities.Test, Models.Test>()
                .ReverseMap()
                .ForMember(dist => dist.PatientId, o => o.MapFrom(src => src.Patient.Id))
                .ForMember(dist => dist.Patient, o => o.Ignore());
        }
    }
}
