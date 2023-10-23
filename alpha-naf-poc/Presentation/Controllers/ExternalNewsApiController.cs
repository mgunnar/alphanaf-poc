using alpha_naf_poc.Domain.Interfaces;
using alpha_naf_poc.Persistence.DTOS;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace alpha_naf_poc.Presentation.Controllers;

[ApiController]
[Route("todos")]
public class ExternalNewsApiController : ControllerBase
{
    private readonly IExternalApi _externalApi;

    public ExternalNewsApiController(IExternalApi externalApi)
    {
        _externalApi = externalApi;
    }

    [HttpGet]
    public async Task<Response> GetTodos([FromQuery] string country,
        [FromQuery] string apiKey)
    {
        return await _externalApi.GetTopHeadLines(country, apiKey);
    }
}






