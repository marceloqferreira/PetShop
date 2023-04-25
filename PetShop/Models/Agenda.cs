using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Agenda
    {
        private long id;
        private DateTime diaHora;
        private Veterinario vet;
        private Pet bichinho;
        private long vetId;
        private long bichinhoId;

        [Key]
        public long Id { get => id; set => id = value; }

        [Display(Name ="Data e hora de atendimento")]
        public DateTime DiaHora { get => diaHora; set => diaHora = value; }
        
        [Display(Name ="Veterinário")]
        public Veterinario Vet { get => vet; set => vet = value; }
        
        [Display(Name ="Pet")]
        public Pet Bichinho { get => bichinho; set => bichinho = value; }
        public long VetId { get => vetId; set => vetId = value; }
        public long BichinhoId { get => bichinhoId; set => bichinhoId = value; }
    }
}
