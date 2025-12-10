using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

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
