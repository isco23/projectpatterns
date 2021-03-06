﻿using AutoMapper;
using FirstAppEFCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppEFCore.MappingConfigurations
{
    public class StudentMapping : Profile
    {
        public StudentMapping()
        {
            CreateMap<Student, VMStudent>()                
                .ReverseMap();                
        }
    }
}
