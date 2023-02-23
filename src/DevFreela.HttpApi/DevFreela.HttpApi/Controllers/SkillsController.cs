using DevFreela.Application.Skills.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SkillsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllSkillsQuery = new GetAllSkillsQuery();

            var skills = await _mediator.Send(getAllSkillsQuery);

            return Ok(skills);
        }
    }
}
