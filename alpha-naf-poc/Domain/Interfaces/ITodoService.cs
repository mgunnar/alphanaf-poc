using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Interfaces;

public interface ITodoService
{
    public Task<IEnumerable<Todo>> GetTodos();
}