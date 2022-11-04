using AutoMapper;
using Avtobus1BLL.DTOs;
using Avtobus1DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1BLL.AutoMapper
{
    public class UrlMapperProfile : Profile
    {
        public UrlMapperProfile() 
        {
            CreateMap<UrlEntity, CreateUrlDTO>();
            CreateMap<CreateUrlDTO, UrlEntity>();

            CreateMap<UrlEntity,UrlElementDTO>();
            CreateMap<UrlElementDTO, UrlEntity>();
        }

    }
}
