﻿using System;
using System.Collections.Generic;
using RestApiCourceTurorial.Domain;

namespace RestApiCourceTurorial.Services
{
    public interface IPostService
    {
        List<Post> GetPosts();
        Post GetPostId(Guid postId);
    }
}
