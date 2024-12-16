using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task.Delete;
using TaskManager.Application.UseCases.Task.GetAllTasks;
using TaskManager.Application.UseCases.Task.GetById;
using TaskManager.Application.UseCases.Task.Register;
using TaskManager.Application.UseCases.Task.Update;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestTaskJson request)
        {
            var useCase = new RegisterTaskUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTasksUseCase();
            var response = useCase.Execute();

            if (response.Tasks.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(string id)
        {
            var useCase = new GetTasksByIdUseCase();
            var response = useCase.Execute(id);
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] string id, [FromBody] RequestTaskJson request)
        {
            var useCase = new UpdateTasksUseCase();
            useCase.Execute(id, request);
            return NoContent();
        }

        [HttpDelete]
        [Route ("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(string id)
        {
            var useCase = new DeleteTaskByIdUseCase();
            useCase.Execute(id);
            return NoContent();
        }
    }
}
