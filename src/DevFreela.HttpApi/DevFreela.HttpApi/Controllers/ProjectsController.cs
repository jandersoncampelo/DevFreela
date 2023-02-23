using DevFreela.Application.Projects.Command;
using DevFreela.Application.Projects.Commands;
using DevFreela.Application.Projects.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;

namespace DevFreela.HttpApi.Controllers;

[Route("api/projects")]
[ApiController]
public class ProjectsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProjectsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get(string query)
    {
        var getAllProjectsQuery = new GetAllProjectsQuery(query);
        var projects = await _mediator.Send(getAllProjectsQuery);

        return Ok(projects);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"Hello World {id}");
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateProjectCommand command)
    {
        if (command.Title.Length > 50)
        {
            return BadRequest("Title must be less than 50 characters");
        }

        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] UpdateProjectCommand command)
    {
        if (id == int.Empty || command.Description.Length > 255)
        {
            return BadRequest();
        }

        await _mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var command = new DeleteProjectCommand(id);

        await _mediator.Send(command);

        return NoContent();
    }

    [HttpPut("{id}/start")]
    public IActionResult Start(int id)
    {
        return Ok($"Hello World {id}");
    }

    [HttpPut("{id}/finish")]
    public IActionResult Finish(int id)
    {
        return Ok($"Hello World {id}");
    }
    
    [HttpPost("{id}/comments")]
    public IActionResult PostComment(int id, [FromBody] string comment)
    {
        return Ok();
    }
}
