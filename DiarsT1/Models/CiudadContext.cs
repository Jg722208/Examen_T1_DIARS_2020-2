using DiarsT1.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT1.Models
{
    public class CiudadContext : DbContext
    {
        public DbSet<Ciudad> Categorys { get; set; }

        public CiudadContext(DbContextOptions<CiudadContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CiudadMap());
        }
    }
}
