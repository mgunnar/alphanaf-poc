using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Repository;

public interface ExternalNewsRepository
{
    public Task<IEnumerable<Todo>> GetExternalNews();
}