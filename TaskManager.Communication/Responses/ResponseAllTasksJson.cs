﻿namespace TaskManager.Communication.Responses
{
    public class ResponseAllTasksJson
    {
        public List<ResponseShortTasksJson> Tasks { get; set; } = [];
    }
}
