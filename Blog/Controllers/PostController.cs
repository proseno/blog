using System.Collections.Generic;
using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        private readonly PostService _postService;

        public PostController(PostService postService)
        {
            _postService = postService;
        }

        public ViewResult Post()
        {
            var posts = _postService.Get();
            return View(model: posts);
        }
        
    }
}