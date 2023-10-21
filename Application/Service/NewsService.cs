using Persistence.Models;
using Domain.Interfaces;

namespace Application.Service;

public class NewsService : INewsService
{
    private readonly INewsRepository _newsRepository;

    public NewsService(INewsRepository newsRepository)
    {
        _newsRepository = newsRepository;
    }
    public async Task<IEnumerable<NewsArticles>> GetNewsArticles(int days)
    {
        return await _newsRepository.GetNewsArticles(days);
    }
}
