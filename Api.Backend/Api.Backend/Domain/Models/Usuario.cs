﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Api.Backend.Enums;
using System.Text.Json.Serialization;

namespace Api.Backend.Domain.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo de senha é obrigatório")]
        public string Senha { get; set; }

        public Boolean Ativo { get; set; }

        public Funcao Funcao { get; set; }

        public virtual List<Instituicao> Instituicaos { get; set; }


    }
}
