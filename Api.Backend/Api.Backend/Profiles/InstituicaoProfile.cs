using Api.Backend.Data.Dtos.Instituicao;
using Api.Backend.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Profiles
{
    public class InstituicaoProfile : Profile
    {
        public InstituicaoProfile()
        {
            CreateMap<CreateInstituicaoDto, Instituicao>();
            CreateMap<Instituicao, ReadInstituicaoDto>();
            CreateMap<UpdateInstituicaoDto, Instituicao>();
        }
    }
}