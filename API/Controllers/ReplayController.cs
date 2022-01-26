using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.PostDto;
using API.Models;
using API.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/post/{postId}/replay")]
    public class ReplayController : ControllerBase
    {
        private readonly IReplay _replay;
        private readonly IMapper _mapp;

        public ReplayController(IReplay replay, IMapper mapp)
        {
            _replay = replay;
            _mapp = mapp;
        }

        [HttpGet]
        public IActionResult GetReplayById(int postId)
        {
            var model = _replay.GetAllReplayByPostId(postId);
            var mapModel = _mapp.Map<IEnumerable<ShowReplayDto>>(model);
            return Ok(mapModel);
        }
        [HttpPost]
        public async Task<ActionResult> PostNewReply(int postId , CreateReplayDto createReplayDto)
        {
            var mapModel = _mapp.Map<PostReplay>(createReplayDto);
            await _replay.AddReplayByPostId(postId,mapModel);
            return Ok();

        }


    }
}