using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.Register
{
    public class RegisterTaskUseCase
    {
        public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
        {
            return new ResponseRegisteredTaskJson
            {
                Id = request.Id,
                Name = request.Name,
            };
        }
    }
}
