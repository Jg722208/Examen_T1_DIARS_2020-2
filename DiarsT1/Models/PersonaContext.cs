using DiarsT1.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT1.Models
{
    public class PersonaContext : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public IEnumerable<object> Ciudad { get; internal set; }

        public PersonaContext(DbContextOptions<PersonaContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PersonaMap());
            modelBuilder.ApplyConfiguration(new CiudadMap());
        }
    }
}
