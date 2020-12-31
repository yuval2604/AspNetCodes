using AutoMapper;
using RestApiCourceTurorial.Contracts.V1.Requests.Queries;
using RestApiCourceTurorial.Domain;

namespace Tweetbook.MappingProfiles
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<PaginationQuery, PaginationFilter>();
            CreateMap<GetAllPostsQuery, GetAllPostsFilter>();
        }
    }
}