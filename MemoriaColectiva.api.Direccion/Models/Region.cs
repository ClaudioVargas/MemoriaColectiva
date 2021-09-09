using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoriaColectiva.Api.Direccion.Models
{
    public class Region
    {
        public Guid RegionId { get; set; }
        public Guid CountryId { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
    }
}
