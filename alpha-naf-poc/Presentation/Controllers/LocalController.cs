using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using alpha_naf_poc.Repository;
using alpha_naf_poc.Service;
using alpha_naf_poc.Context;
using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Presentation.Controllers;

[ApiController]
[Route("news")]
[OpenApiTag("News", Description = "News Articles")]
public class LocalController : ControllerBase
{
    private readonly NewsService _newsService;
    private readonly NewsRepository _newsRepository;
    private readonly NewsArticlesContext _newsArticlesContext;

    public LocalController(NewsArticlesContext newsArticlesContext)
    {
        _newsArticlesContext = newsArticlesContext;
        _newsRepository = new NewsRepository(_newsArticlesContext);
        _newsService = new NewsService(_newsRepository);
    }

    [HttpGet]
    public async Task<IEnumerable<NewsArticle>> GetNewsArticles(int days)
    {
        return await _newsService.GetNewsArticles(days);
    }
}
