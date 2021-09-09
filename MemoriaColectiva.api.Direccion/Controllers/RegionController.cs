using MediatR;
using MemoriaColectiva.Api.Direccion.Applications;
using MemoriaColectiva.Api.Direccion.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoriaColectiva.Api.Direccion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RegionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<DefaultResponse>> Region(NewRegion.Execute data)
        {
            var result = await _mediator.Send(data);

            return new DefaultResponse
            {
                Status = 200,
                Data = result
            };
        }
    }
}
