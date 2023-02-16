using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.HttpApi.Controllers;

[Route("api/projects")]
[ApiController]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"Hello World {id}");
    }

    [HttpPost]
    public IActionResult Post([FromBody] string name)
    {
        return Ok($"Hello World {name}");
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id)
    {
        return Ok($"Hello World {id}");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Ok($"Hello World {id}");
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
