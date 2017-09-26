using AutoMapper;
using MadplanVbkAsp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadplanVbkAsp.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SharedLib.Models.Food, FoodDto>();
            CreateMap<FoodDto, SharedLib.Models.Food>();
        }
    }
}
