using System;
using RestApiCourceTurorial.Contracts.V1.Requests.Queries;

namespace RestApiCourceTurorial.Services
{
    public interface IUriService
    {
        Uri GetPostUri(string postId);

        Uri GetAllPostsUri(PaginationQuery pagination = null);
    }
}