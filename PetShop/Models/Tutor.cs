using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    
    public class Tutor
    {
        private long id;
        private string nome;
        private string telefone;
        private ICollection<Pet> meusPets;

        [Key]
        public long Id { get => id; set => id = value; }

        [MaxLength(25)]
        [Required]
        public string Nome { get => nome; set => nome = value; }
        [MaxLength(16)]
        [Required]
        public string Telefone { get => telefone; set => telefone = value; }
        public ICollection<Pet> MeusPets { get => meusPets; set => meusPets = value; }
    }
}
