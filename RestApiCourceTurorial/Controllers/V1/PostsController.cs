using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestApiCourceTurorial.Contract;
using RestApiCourceTurorial.Contract.V1.Requests;
using RestApiCourceTurorial.Contract.V1.Responses;
using RestApiCourceTurorial.Domain;
using RestApiCourceTurorial.Services;

namespace Tweetbook.Controllers.V1
{
   
    public class PostsController : Controller
    {
        private IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public IActionResult GetAll()
        {
            return Ok(_postService.GetPosts());
        }

        [HttpPut(ApiRoutes.Posts.Update)]
        public IActionResult Update([FromRoute] Guid postId, [FromBody] UpdatedPostRequest request)
        {
            var post = new Post
            {
                Id = postId,
                Name = request.Name

            };
            var updated = _postService.UpdatePost(post);
            if(updated)
                return Ok(post);
            return NotFound();
        }

        [HttpGet(ApiRoutes.Posts.Get)]
        public IActionResult Get([FromRoute]Guid postId)
        {
            var post = _postService.GetPostId(postId);
            if (post == null) return NotFound();
            return Ok(post);
        }

        [HttpPost(ApiRoutes.Posts.Create)]
        public IActionResult Create([FromBody] CreatedPostRequest postRequest)
        {
            var post = new Post { Id = postRequest.Id };
            if (post.Id != Guid.Empty) post.Id = Guid.NewGuid();
            //_postService.Add(post);

            var baseurl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUrl = baseurl + "/" + ApiRoutes.Posts.Get.Replace("{postId}", post.Id.ToString());
            var response = new PostResponse { Id = post.Id };
            return Created(locationUrl, response);
        }


        [HttpDelete(ApiRoutes.Posts.Delete)]
        public IActionResult Delete([FromRoute] Guid postId)
        {
            var deleted = _postService.DeletePost(postId);
            if (deleted) return NoContent();
            return NotFound();
        }

    }
}