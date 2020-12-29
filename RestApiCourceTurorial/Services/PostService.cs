using System;
using System.Collections.Generic;
using System.Linq;
using RestApiCourceTurorial.Domain;

namespace RestApiCourceTurorial.Services
{
    public class PostService : IPostService
    {
        private readonly List<Post> _posts;

        public PostService()
        {
            _posts = new List<Post>();
            for (int i = 0; i < 5; i++)
            {
                _posts.Add(new Post
                {
                    Id = Guid.NewGuid(),
                    Name = $"Post name {i}"
                });
            }
        }

        public List<Post> GetPosts()
        {
            return _posts;

        }

        public Post GetPostId(Guid postId)
        {
            return _posts.SingleOrDefault(x => x.Id == postId);
        }

        public bool UpdatePost(Post postToUpdate)
        {
            var exsists = GetPostId(postToUpdate.Id) != null;
            if (!exsists) return false;
            var index = _posts.FindIndex(x => x.Id == postToUpdate.Id);
            _posts[index] = postToUpdate;
            return true;
        }

        public bool DeletePost(Guid postId)
        {
            var post = GetPostId(postId);
            if (post == null) return false;
            _posts.Remove(post);
            return true;
        }
    }
}
