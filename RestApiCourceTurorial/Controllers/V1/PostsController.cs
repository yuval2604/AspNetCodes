﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestApiCourceTurorial.Contract;
using RestApiCourceTurorial.Contract.V1.Requests;
using RestApiCourceTurorial.Contract.V1.Responses;
using RestApiCourceTurorial.Domain;
using RestApiCourceTurorial.Services;

namespace Tweetbook.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PostsController : Controller
    {
        private IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _postService.GetPostsAsync());
        }

        [HttpPut(ApiRoutes.Posts.Update)]
        public async Task<IActionResult> Update([FromRoute] Guid postId, [FromBody] UpdatedPostRequest request)
        {
            var post = new Post
            {
                Id = postId,
                Name = request.Name

            };
            var updated = await _postService.UpdatePostAsync(post);
            if(updated)
                return Ok(post);
            return NotFound();
        }

        [HttpGet(ApiRoutes.Posts.Get)]
        public async Task<IActionResult> Get([FromRoute]Guid postId)
        {
            var post = _postService.GetPostByIdAsync(postId);
            if (post == null) return NotFound();
            return Ok(post);
        }

        [HttpPost(ApiRoutes.Posts.Create)]
        public async Task<IActionResult> Create([FromBody] CreatedPostRequest postRequest)
        {
            var post = new Post { Name = postRequest.Name };
            
            await _postService.CreatePostAsync(post);

            var baseurl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUrl = baseurl + "/" + ApiRoutes.Posts.Get.Replace("{postId}", post.Id.ToString());
            var response = new PostResponse { Id = post.Id };
            return Created(locationUrl, response);
        }


        [HttpDelete(ApiRoutes.Posts.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid postId)
        {
            var deleted = await _postService.DeletePostAsync(postId);
            if (deleted) return NoContent();
            return NotFound();
        }

    }
}