using alpha_naf_poc.Domain.Models;
using alpha_naf_poc.DTOS;

namespace alpha_naf_poc.Interfaces;

public interface INewsRepository
{
    Task<IEnumerable<NewsArticle>> GetNewsArticles(int days);
    Task<IEnumerable<NewsArticle>> AddNewsArticles(IEnumerable<NewsArticle> news);
}
