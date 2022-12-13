using GithubTrial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GithubTrial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
		public TodoController()
		{

		}

		[HttpGet("/Todos")]
		public IActionResult GetAllTodos()
		{
			List<Todos> todos = new List<Todos>()
			{
				new Todos { Id = 1, Todo = "Get food", TodoPriority = "High"},
                                new Todos { Id = 2, Todo = "Go to gym", TodoPriority = "Medium"},
                                new Todos { Id = 3, Todo = "Watch movie", TodoPriority = "Low"}
                        };

			return Ok(todos);

		}

    }
}
