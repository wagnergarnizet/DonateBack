using Api.Backend.Data.Dtos.Estoque;
using Api.Backend.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Profiles
{
    public class EstoqueProfile : Profile
    {
        public EstoqueProfile()
        {
            CreateMap<CreateEstoqueDto, Estoque>();
            CreateMap<Estoque, ReadEstoqueDto>();
            CreateMap<UpdateEstoqueDto, Estoque>();
        }
    }
}