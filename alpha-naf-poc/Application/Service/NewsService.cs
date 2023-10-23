using alpha_naf_poc.Interfaces;
using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Service;

public class NewsService : INewsService
{
    private readonly INewsRepository _newsRepository;

    public NewsService(INewsRepository newsRepository)
    {
        _newsRepository = newsRepository;
    }
    public async Task<IEnumerable<NewsArticle>> GetNewsArticles(int days)
    {
        return await _newsRepository.GetNewsArticles(days);
    }
}
