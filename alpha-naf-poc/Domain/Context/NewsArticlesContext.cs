using Microsoft.EntityFrameworkCore;
using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Context;

public class NewsArticlesContext : DbContext
{
    public NewsArticlesContext(DbContextOptions<NewsArticlesContext> options) : base(options)
    {

    }

    public DbSet<NewsArticle> NewsArticles { get; set; }
}