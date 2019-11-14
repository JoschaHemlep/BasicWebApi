using AutoMapper;
using BasicWebApi.Dtos;
using DbAccess.Models;

namespace BasicWebApi
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ExampleModel, ExampleDto>();
        }
    }
}