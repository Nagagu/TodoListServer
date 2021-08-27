using Microsoft.EntityFrameworkCore;
using TodoListServer.Entities;

namespace TodoListServer.BBDD
{
    public interface IToDoDbContext
    {
        DbSet<ToDo> ToDos { get; set; }

        int SaveChanges();
    }
}