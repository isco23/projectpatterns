using AutoMapper;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Models;
using FirstAppEFCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppEFCore.MappingConfigurations
{
    public class AwardMapping : Profile
    {
        public AwardMapping()
        {
            CreateMap<Award, VMAward>();
        }
    }
}
