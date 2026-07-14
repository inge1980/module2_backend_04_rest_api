/* 
using core.Models;
using core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.models.dto;

namespace aspnetintro.Controllers;

[Route("/[controller]/")]
[ApiController]
public class RepairController(RepairRepository repository) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<NewRepairForm> Get() => repository.GetAll();
    
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Get(Guid id) => repository.FindById(id) is Success<NewRepairForm> success ? Ok(success.Value) : NotFound();
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult Post([FromBody] NewRepairFormDto dto)
    {
        var result = dto.BuildForm();
        return result switch
        {
            Success<NewRepairForm> success => Created($"/repair/{success.Value.Id}", success.Value),
            Error error => BadRequest(new {message = error.Message}),
            _ => StatusCode(500, new {message = "Something went terribly wrong" })
        };
    }


}
 */