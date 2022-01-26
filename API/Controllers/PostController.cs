using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.PostDto;
using API.Models;
using API.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NpgsqlTypes;

namespace API.Controllers
{   [ApiController]
    [Route("api/post")]
    public class PostController : ControllerBase
    {
        private readonly IPost _post;
        private readonly IMapper _mapp;

        public PostController(IPost post, IMapper mapp)
        {
            _post = post;
            _mapp = mapp;
        }
        
        [HttpGet]
        public IActionResult GetAllPosts()
        {
            var model = _post.GetAllPosts();
           
            var mapModel = _mapp.Map<IEnumerable<ShowPostDto>>(model);
            
            return Ok(mapModel);
        }
        [HttpGet("{id}")]
        public ActionResult GetPostById(int id)
        {
            var model = _post.GetPostById(id);
            
            if(model != null)
            {
                var mapModel = _mapp.Map<ShowPostDto>(model);
                return Ok(mapModel);
            }
            return NotFound();
            
        }
      
        [HttpPost]
        public async Task<ActionResult> PostNewPost([FromBody]CreatePostDto createPostDto)
        {   
            
            var mapModel = _mapp.Map<Post>(createPostDto);
            await _post.CreatePost(mapModel);
            return Ok();
        }



    }
}