using alpha_naf_poc.Domain.Constants;
using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.DTOS;

public class NewsResponseDTO
{
    public Statuses Status { get; set; }
    public ErrorCodes? Code { get; set; }
    public string Message { get; set; }
    public List<NewsArticle> Articles { get; set; }
    public int TotalResults { get; set; }
}