using DomoMeteoXamarin.DTO;
using DomoMeteoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microcharts;

namespace DomoMeteoXamarin.Configure
{
    public static class AutomapperConfig
    {


        public static void Configure()
        {
            AutoMapper.Mapper.Reset();

            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<SensorDTO, Sensor>()
                   .ForMember(g => g.Data, opt => opt.MapFrom(src => src.Data))
                   .ForMember(g => g.Name, opt => opt.MapFrom(src => src.Name));

                config.CreateMap<TempHumMonthValueDTO, Entry>()
               .ForMember(g => g.Label, opt => opt.MapFrom(src => src.Date))
               .ForMember(g => g.ValueLabel, opt => opt.MapFrom(src => src.Temperature))
               .ForMember(g => g.Value, opt => opt.MapFrom(src => float.Parse(src.Temperature)));
        });

            //AutoMapper.Mapper.Initialize(config => config.CreateMap<SensorsDTO, Sensor>()
            //   .ForMember(g => g.Data, opt => opt.MapFrom(src => src.Data))
            //   .ForMember(g => g.Name, opt => opt.MapFrom(src => src.Name)));

        }
    }
}
