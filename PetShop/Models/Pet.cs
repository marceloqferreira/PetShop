using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Pet
    {
        private long id;
        private string nome;
        private string raca;
        private string cor;
        private Tutor dono;
        private long donoId;

        [Key]
        public long Id { get => id; set => id = value; }
        [MaxLength(15)]
        public string Nome { get => nome; set => nome = value; }
        [MaxLength(20)]
        public string Raca { get => raca; set => raca = value; }

        [MaxLength(20)]
        public string Cor { get => cor; set => cor = value; }
        public Tutor Dono { get => dono; set => dono = value; }
        public long DonoId { get => donoId; set => donoId = value; }
    }
}
