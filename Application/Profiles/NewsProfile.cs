using Persistence.Models;
using AutoMapper;
using Persistence.DTOS;
namespace Application.Profiles;

public class NewsProfile : Profile
{
    public NewsProfile()
    {
        CreateMap<NewsArticles, NewsResponseDTO>();
    }
}
