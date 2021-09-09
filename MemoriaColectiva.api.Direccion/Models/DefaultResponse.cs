using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoriaColectiva.Api.Direccion.Models
{
    public class DefaultResponse
    {
        public int Status { get; set; }
        public Object Data { get; set; }
        public string? Message { get; set; }
    }
}
