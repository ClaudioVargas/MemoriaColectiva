using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemoriaColectiva.Api.Direccion.Models;

namespace MemoriaColectiva.Api.Direccion.Persistence
{
    public class CountryContext: DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options): base(options) { }

        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>()
                .HasIndex(u => u.Name)
                .IsUnique();
        }
    }
}
