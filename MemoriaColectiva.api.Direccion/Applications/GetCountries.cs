using MediatR;
using MemoriaColectiva.Api.Direccion.Models;
using MemoriaColectiva.Api.Direccion.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MemoriaColectiva.Api.Direccion.Applications
{
    public class GetCountries
    {

        public class Execute: IRequest<List<Country>> { }

        public class OnHandle : IRequestHandler<Execute, List<Country>>
        {
            private readonly CountryContext _context;
            public OnHandle(CountryContext context)
            {
                _context = context;
            }

            public async Task<List<Country>> Handle(Execute request, CancellationToken cancellationToken)
            {
                var countries = await _context.Country.ToListAsync();
                return countries;
                
            }


        }
    }
}
