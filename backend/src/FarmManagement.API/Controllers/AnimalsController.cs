using FarmManagement.Application.Animals.Commands;
using FarmManagement.Application.Animals.Dtos;
using FarmManagement.Application.Animals.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FarmManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AnimalsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AnimalDto>> Get(Guid id)
        {
            var dto = await _mediator.Send(new GetAnimalByIdQuery(id));
            if (dto == null) return NotFound();

            return Ok(dto);
        }
    }
}
