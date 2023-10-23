using Microsoft.EntityFrameworkCore;
using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Context;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {

    }

    public DbSet<Todo> Todos { get; set; }
}