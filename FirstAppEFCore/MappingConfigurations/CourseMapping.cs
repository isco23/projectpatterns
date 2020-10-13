using AutoMapper;
using FirstAppEFCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppEFCore.MappingConfigurations
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<Course, VMCourse>();
        }        
    }
}
