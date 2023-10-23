using alpha_naf_poc.Context;
using alpha_naf_poc.Interfaces;
using Microsoft.EntityFrameworkCore;
using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Repository;
public class NewsRepository : INewsRepository
{
    private readonly NewsArticlesContext _newsArticlesContext;

    public NewsRepository(NewsArticlesContext context)
    {
        _newsArticlesContext = context;
    }

    public async Task<IEnumerable<NewsArticle>> GetNewsArticles(int days)
    {
        return await _newsArticlesContext.NewsArticles
            .Where(n => n.PublishedAt >= DateTime.Now.AddDays(-days))
            .ToListAsync();
  
    }

    public async Task<IEnumerable<NewsArticle>> AddNewsArticles(IEnumerable<NewsArticle> news)
    {
        await _newsArticlesContext.NewsArticles.AddRangeAsync(news);
        await _newsArticlesContext.SaveChangesAsync();
        return news;
    }
}