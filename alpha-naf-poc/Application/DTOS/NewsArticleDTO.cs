namespace alpha_naf_poc.DTOS;

public class NewsArticleDTO
{
    public NewsSourceDTO? Source { get; set; }
    public string? Author { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Url { get; set; }
    public string? UrlToImage { get; set; }
    public DateTime? PublishedAt { get; set; }
    public string? Content { get; set; }
}