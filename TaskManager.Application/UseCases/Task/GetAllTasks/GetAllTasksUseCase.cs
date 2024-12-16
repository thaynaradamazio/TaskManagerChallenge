using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetAllTasks
{
    public class GetAllTasksUseCase
    {
        public ResponseAllTasksJson Execute()
        {
            return new ResponseAllTasksJson()
            {
                Tasks = new List<ResponseShortTasksJson>
                {
                    new ResponseShortTasksJson
                    {
                        Id = "1",
                        Name = "organizar",
                        Priority = Communication.Enums.TaskPriority.High,
                        Status = Communication.Enums.TaskStatus.Completed,
                    }
                }
            };
        }
    }
}
