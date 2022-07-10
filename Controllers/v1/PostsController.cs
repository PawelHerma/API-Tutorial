﻿using API_Tutorial.Contracts.v1;
using API_Tutorial.Domain;
using Microsoft.AspNetCore.Mvc;

namespace API_Tutorial.Controllers.v1
{
    public class PostsController : Controller
    {
        private List<Post> _posts;
        public PostsController()
        {
            _posts = new List<Post>();
            for (var i = 0; i < 5; i++)
            {
                _posts.Add(new Post { Id = Guid.NewGuid().ToString() });
            }
        }
        [HttpGet(ApiRoutes.Posts.GetAll)]
        public IActionResult GetAll()
        {
            return Ok(_posts);
        }
    }
}
