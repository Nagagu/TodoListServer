using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListServer.BBDD;
using TodoListServer.Entities;

namespace TodoListServer.BL
{
    public class ToDoBL
    {
        private readonly IToDoDbContext _dbContext;

        public ToDoBL(IToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        

        public void Add(ToDo todo)
        {
            _dbContext.ToDos.Add(todo);
            _dbContext.SaveChanges();
        }

        public List<ToDo> GetAll()
        {
            return _dbContext.ToDos.ToList();
        }

        public void MarkToDo(Guid id, bool isDone)
        {
            var data = _dbContext.ToDos.FirstOrDefault(o => o.Id == id);
            data.IsDone = isDone; 
            _dbContext.SaveChanges();
        }

        public List<ToDo> GetPendingToDos()
        {
            return _dbContext.ToDos.Where(o => o.IsDone == false).ToList();
        }
    }
}
