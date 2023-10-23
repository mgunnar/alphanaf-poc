using alpha_naf_poc.Domain.Constants;
using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Persistence.DTOS;

public class Response
{
    public Statuses Status { get; set; }
    public Error Error { get; set; }
    public int TotalResults { get; set; }
    public List<NewsArticle> Articles { get; set; }
}
