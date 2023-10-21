using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using Domain.Context;
using Persistence.Models;
using Repository.Repository;
using Application.Service;

namespace alpha_naf_poc.Controllers;

[ApiController]
[Route("news")] 
[OpenApiTag("News", Description = "News Articles")]
public class HomeController : ControllerBase
{
    private readonly NewsService _newsService;
    private readonly NewsRepository _newsRepository;
    private readonly NewsArticlesContext _newsArticlesContext;

    public HomeController(NewsArticlesContext newsArticlesContext)
    {
        _newsArticlesContext = newsArticlesContext;
        _newsRepository = new NewsRepository(_newsArticlesContext);
        _newsService = new NewsService(_newsRepository);
    }

    [HttpGet]
    public async Task<IEnumerable<NewsArticles>> GetNewsArticles(int days)
    {
        return await _newsService.GetNewsArticles(days);
    }
}
