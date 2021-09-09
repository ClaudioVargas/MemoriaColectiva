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
    public class NewRegion
    {
        public class Execute: IRequest
        {
            public Guid CountryId { get; set; }
            public string Name{ get; set; }
        }

        public class OnHandle : IRequestHandler<Execute>
        {
            private RegionContext _context;
            public OnHandle(RegionContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Execute request, CancellationToken cancellationToken)
            {
                var region = new Region
                {
                    CountryId = request.CountryId,
                    Name = request.Name
                };
                _context.Add(region);
                var result = await _context.SaveChangesAsync();
                if(result > 0 )
                {
                    return Unit.Value;
                }
                throw new Exception("No fue posible ");
            }
        }
    }
}
