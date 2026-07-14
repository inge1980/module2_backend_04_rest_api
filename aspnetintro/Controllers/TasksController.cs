using aspnetintro.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnetintro.Controllers;

[Route("/[controller]/")]
[ApiController]
public class TasksController : ControllerBase
{
    private static readonly List<TaskItem> tasks = new()
    {
        new TaskItem
        {
            Id = 1,
            Title = "Learn ASP.NET Core",
            Description = "Build REST API with Controllers",
            Status = TaskItemStatus.Open,
            CreatedAt = DateTime.Now,
            DueDate = DateTime.Now.AddDays(7)
        },
        new TaskItem
        {
            Id = 2,
            Title = "Write README",
            Description = "Document API endpoints",
            Status = TaskItemStatus.Completed,
            CreatedAt = DateTime.Now.AddDays(-2),
            DueDate = null
        }
    };


    /// <summary>
    /// Henter alle oppgaver.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<TaskItem> Get()
    {
        return tasks;
    }


    /// <summary>
    /// Henter én oppgave basert på id.
    /// </summary>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            return NotFound();
        }

        return Ok(task);
    }
}