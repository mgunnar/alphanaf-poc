using alpha_naf_poc.Persistence.DTOS;
using Refit;

namespace alpha_naf_poc.Domain.Interfaces;
public interface IExternalApi
{
    [Get("/top-headlines")]
      Task<Response> GetTopHeadLines([AliasAs("country")] string country, [AliasAs("apiKey")] string token);
}