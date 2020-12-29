using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestApiCourceTurorial.Domain;

namespace RestApiCourceTurorial.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPostsAsync();
        Task<Post> GetPostByIdAsync(Guid postId);
        Task<bool> CreatePostAsync(Post post);
        Task<bool> DeletePostAsync(Guid postId);
        Task<bool> UpdatePostAsync(Post postToUpdate);
    }
}
