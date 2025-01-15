using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data
{
    public class TodoListDbContext : DbContext
    {
        public DbSet<Tache> Taches { get; set; }
    }
}
