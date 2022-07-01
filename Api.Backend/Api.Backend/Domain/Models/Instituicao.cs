﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Api.Backend.Models
{
    public class Instituicao
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de Cnpj é obrigatório")]
        public string Cnpj { get; set; }

        public string Endereco { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Bairro { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string Logotipo { get; set; }

        public bool Ativo { get; set; }

        public string Descricao { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public virtual Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<Campanha> Campanhas { get; set; }

    }
}

