using alpha_naf_poc.Domain.Interfaces;
using alpha_naf_poc.DTOS;
using alpha_naf_poc.Interfaces;
using alpha_naf_poc.Domain.Models;
using alpha_naf_poc.Persistence.DTOS;
using alpha_naf_poc.Repository;

namespace alpha_naf_poc.Service;
public class ExternalNewsApiService : IExternalApi
{
    private readonly IExternalApi _externalApi;

    public ExternalNewsApiService(IExternalApi externalApi)
    {
        _externalApi = externalApi;
    }

    public Task<Response> GetTopHeadLines(string country, string apiKey)
    {
        return _externalApi.GetTopHeadLines(country, apiKey);
    }
}
