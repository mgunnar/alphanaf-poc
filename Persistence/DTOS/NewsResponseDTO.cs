using Persistence.Models;

namespace Persistence.DTOS
{
    public class NewsResponseDTO
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<NewsArticles> NewsArticles { get; set; }
    }
}
