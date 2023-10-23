using alpha_naf_poc.Context;
using Microsoft.EntityFrameworkCore;
using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Repository;
public class TodoRepository : ExternalNewsRepository
{
    private readonly TodoContext _todoContext;

    public TodoRepository(TodoContext context)
    {
        _todoContext = context;
    }

    public async Task<IEnumerable<Todo>> GetExternalNews()
    {
        return await _todoContext.Todos
            .ToListAsync();
    }
}