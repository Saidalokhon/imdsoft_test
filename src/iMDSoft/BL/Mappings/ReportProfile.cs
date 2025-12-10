using AutoMapper;

namespace BL.Mappings
{
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            CreateMap<DAL.Entities.Report, Models.Report>()
                .ReverseMap();
        }
    }
}
