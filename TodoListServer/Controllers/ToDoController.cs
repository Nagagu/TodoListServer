using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListServer.BL;
using TodoListServer.Entities;

namespace TodoListServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoBL _toDoBL;

        public ToDoController(ToDoBL toDoBL)
        {
            _toDoBL = toDoBL;
        }

        [Route("[action]")]
        [HttpPost]
        public Guid Add(ToDo todo)
        {
            todo.Id = Guid.NewGuid();
            _toDoBL.Add(todo);
            return todo.Id;
        }


        [Route("[action]")]
        [HttpGet]
        public List<ToDo> GetAll()
        {
            return _toDoBL.GetAll();
        }


        [Route("[action]")]
        [HttpPost]

        public void MarkToDo(MarkTodoRequest request)
        {
            _toDoBL.MarkToDo(request.id, request.isDone);

        }


        //[Route("[action]")]
        //[HttpPost]

        //public void MarkDone(Guid id)
        //{
        //   return _toDoBL.MarkToDo(id, true)
        //}

        //[Route("[action]")]
        //[HttpPost]
        //public void MarkUndone(Guid id)
        //{
        //    return _toDoBL.MarkToDo(id, false)
        //}
        //MarkToDoDone

        //    GetPendingToDos
    }
}
