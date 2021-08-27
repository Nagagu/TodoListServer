using System;

namespace TodoListServer.Controllers
{
    public class MarkTodoRequest
    {
        public Guid id { get; set; }
        public bool isDone { get; set; }
    }
}
