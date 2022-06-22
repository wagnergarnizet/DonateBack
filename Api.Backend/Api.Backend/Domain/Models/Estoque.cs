﻿using Api.Backend.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Backend.Models
{
    public class Estoque
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("Fk_estoque_produto")]
        public virtual Produto Produto { get; set; }

        [ForeignKey("Fk_estoque_campanha")]
        public virtual Campanha Campanha { get; set; }

        public int Qtde { get; set; }
        public Tipo Tipo { get; set; }
        public string Observacao { get; set; }


    }
}

