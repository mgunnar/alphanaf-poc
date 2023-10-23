using AutoMapper;
using alpha_naf_poc.DTOS;
using alpha_naf_poc.Domain.Models;

namespace alpha_naf_poc.Profiles;

public class NewsProfile : Profile
{
    public NewsProfile()
    {
        CreateMap<NewsArticle, NewsResponseDTO>();
    }
}
