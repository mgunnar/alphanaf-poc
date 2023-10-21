using Persistence.Models;
namespace Domain.Interfaces;

public interface INewsService
{
    public Task<IEnumerable<NewsArticles>> GetNewsArticles(int days);

}
