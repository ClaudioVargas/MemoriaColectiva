using MemoriaColectiva.Api.Direccion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoriaColectiva.Api.Direccion.Persistence
{
    public class RegionContext: DbContext
    {
        public RegionContext(DbContextOptions<RegionContext> options): base(options) { }
        public DbSet<Region> Region { get; set; }
    }
}
