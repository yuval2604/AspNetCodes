﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestApiCourceTurorial.Contract;
using RestApiCourceTurorial.Contract.V1.Requests;
using RestApiCourceTurorial.Contract.V1.Responses;
using RestApiCourceTurorial.Domain;

namespace Tweetbook.Controllers.V1
{
   
    public class PostsController : Controller
    {
        private List<Post> _posts;

        public PostsController()
        {
            _posts = new List<Post>();
            for(int i = 0; i < 5; i++)
            {
                _posts.Add(new Post { Id = Guid.NewGuid().ToString() });
            }
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public IActionResult GetAll()
        {
            return Ok(_posts);
        }

        [HttpPost(ApiRoutes.Posts.Create)]
        public IActionResult Create([FromBody] CreatedPostRequest postRequest)
        {
            var post = new Post { Id = postRequest.Id };
            if (string.IsNullOrEmpty(post.Id)) post.Id = Guid.NewGuid().ToString();
            _posts.Add(post);

            var baseurl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUrl = baseurl + "/" + ApiRoutes.Posts.Get.Replace("{postId}", post.Id);
            var response = new PostResponse { Id = post.Id };
            return Created(locationUrl, response);
        }

    }
}