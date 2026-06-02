using Microsoft.EntityFrameworkCore;
using ToDoList.Api.Entities;

namespace ToDoList.Api.Data;

public class AppDbContext : DbContext
{
    public DbSet<ToDoItem> ToDoItems { get; set; }
}
