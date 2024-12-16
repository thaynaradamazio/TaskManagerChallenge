using TaskManager.Communication.Enums;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetById
{
    public class GetTasksByIdUseCase
    {
        public ResponseTaskJson Execute(string id)
        {
            return new ResponseTaskJson
            {
               Id = id,
               Name = "viajar",
               Description = "viajar muito",
               Deadline = new DateTime(year: 2023, month: 01, day: 01),
               Priority = TaskPriority.High,
               Status = Communication.Enums.TaskStatus.Doing
            };
        }
    }
}
