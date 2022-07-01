﻿using Api.Backend.Data;
using Api.Backend.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncaoController : ControllerBase
    {
        [HttpGet]
        public Dictionary<String,int> RecuperaFuncoes()
        {
            Dictionary<string, int> funcao = Enum.GetValues(typeof(Funcao))
                                .Cast<Funcao>()
                                .ToDictionary(k => k.ToString(), v => (int)v);

            return funcao;
        }
    }

}
