using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Veterinario : Pessoa
    {
        private long id;
        private string crv;
        private decimal valor;

        [Display(Name ="No. Conselho Regional de Veterinária")]
        [MaxLength(14)]
        public string Crv { get => crv; set => crv = value; }

        [Display(Name ="Valor da consulta")]
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Valor { get => valor; set => valor = value; }
        
        [Key]
        public long Id { get => id; set => id = value; }
    }
}
