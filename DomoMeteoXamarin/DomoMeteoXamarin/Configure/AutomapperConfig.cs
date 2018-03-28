using DomoMeteoXamarin.DTO;
using DomoMeteoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace DomoMeteoXamarin.Configure
{
    public static class AutomapperConfig
    {


        public static void Configure()
        {

            AutoMapper.Mapper.Initialize(config => config.CreateMap<SensorDTO, Sensor>()
               .ForMember(g => g.Data, opt => opt.MapFrom(src => src.Data))
               .ForMember(g => g.Name, opt => opt.MapFrom(src => src.Name)));

            //AutoMapper.Mapper.Initialize(config => config.CreateMap<SensorsDTO, Sensor>()
            //   .ForMember(g => g.Data, opt => opt.MapFrom(src => src.Data))
            //   .ForMember(g => g.Name, opt => opt.MapFrom(src => src.Name)));

        }
    }
}
