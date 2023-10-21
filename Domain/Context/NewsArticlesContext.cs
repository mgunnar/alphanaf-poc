using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Domain.Context;

public class NewsArticlesContext : DbContext
{
    public NewsArticlesContext(DbContextOptions<NewsArticlesContext> options) : base(options)
    {

    }

    public DbSet<NewsArticles> NewsArticles { get; set; }
}