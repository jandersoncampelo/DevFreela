using Microsoft.AspNetCore.Mvc;


namespace DevFreela.HttpApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    // GET: api/<UsersController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(id);
    }

    // POST api/<UsersController>
    [HttpPost]
    public IActionResult Post([FromBody] string value)
    {
        return Ok();
    }

    // PUT api/<UsersController>/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] string value)
    {
        return NoContent();
    }

    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }

    [HttpPost("{id}/login")]
    public IActionResult Login(int id, [FromBody] string password)
    {
        return Ok();
    }

}
