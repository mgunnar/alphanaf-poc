using Persistence.Models;
using Domain.Context;
using Domain.Interfaces;
using Persistence.DTOS;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repository;
public class NewsRepository : INewsRepository
{
    private readonly NewsArticlesContext _newsArticlesContext;

    public NewsRepository(NewsArticlesContext context)
    {
        _newsArticlesContext = context;
    }

    public async Task<IEnumerable<NewsArticles>> GetNewsArticles(int days)
    {
        return await _newsArticlesContext.NewsArticles
            .Where(n => n.PublishedAt >= DateTime.Now.AddDays(-days))
            .ToListAsync();
  
    }

    public async Task<IEnumerable<NewsArticles>> AddNewsArticles(IEnumerable<NewsArticles> news)
    {
        await _newsArticlesContext.NewsArticles.AddRangeAsync(news);
        await _newsArticlesContext.SaveChangesAsync();
        return news;
    }
    
}