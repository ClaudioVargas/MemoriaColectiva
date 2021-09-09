using MediatR;
using MemoriaColectiva.Api.Direccion.Models;
using MemoriaColectiva.Api.Direccion.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MemoriaColectiva.Api.Direccion.Applications
{
    public class NewCountry
    {
        public class Execute: IRequest
        {
            public Guid CountryId { get; set; }
            public string Name { get; set; }
        }

        public class OnHandle : IRequestHandler<Execute>
        {
            private readonly CountryContext _context;
            public OnHandle(CountryContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Execute request, CancellationToken cancellationToken)
            {
                var country = new Country
                {
                    CountryId = new Guid(),
                    Name = request.Name
                };
                _context.Add(country);
                var result = await _context.SaveChangesAsync();
                if(result > 0 )
                {
                    return Unit.Value;
                }

                throw new Exception("Pais registrado correctamente");
            }
        }
    }
}
