using AutoMapper;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppEFCore.MappingConfigurations
{
    public class LessonMapping : Profile
    {
        public LessonMapping()
        {
            CreateMap<Lesson, VMLesson>()
                .ReverseMap();
        }
    }
}
