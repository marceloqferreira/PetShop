using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext (DbContextOptions<PetShopContext> options)
            : base(options)
        {
        }

        public DbSet<PetShop.Models.Tutor> Tutor { get; set; }

        public DbSet<PetShop.Models.Pet> Pet { get; set; }

        public DbSet<PetShop.Models.Veterinario> Veterinario { get; set; }

        public DbSet<PetShop.Models.Agenda> Agenda { get; set; }

        
    }
}
