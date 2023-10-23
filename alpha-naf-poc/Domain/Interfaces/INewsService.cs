using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Interfaces;

public interface INewsService
{
    public Task<IEnumerable<NewsArticle>> GetNewsArticles(int days);

}