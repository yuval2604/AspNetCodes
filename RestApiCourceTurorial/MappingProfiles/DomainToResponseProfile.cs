using System.Linq;
using AutoMapper;
using RestApiCourceTurorial.Contracts.V1.Responses;
using RestApiCourceTurorial.Domain;

namespace Tweetbook.MappingProfiles
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Post, PostResponse>()
                .ForMember(dest => dest.Tags, opt => 
                    opt.MapFrom(src => src.Tags.Select(x => new TagResponse{Name = x.TagName})));
            
            CreateMap<Tag, TagResponse>();
        }
    }
}