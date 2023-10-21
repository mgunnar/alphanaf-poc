using Persistence.DTOS;
using Persistence.Models;

namespace Domain.Interfaces;

public interface INewsRepository
{
    Task<IEnumerable<NewsArticles>> GetNewsArticles(int days);
    Task<IEnumerable<NewsArticles>> AddNewsArticles(IEnumerable<NewsArticles> news);
}
