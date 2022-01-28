using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.ItemDto;
using API.Dtos.PostDto;
using API.Models;

namespace API.Mapper
{
    public class Maps : AutoMapper.Profile
    {
        public Maps()
        {
            
         

       

            //posts
            CreateMap<Post,ShowPostDto>();
            CreateMap<ShowPostDto,Post>();
       
            CreateMap<Post,CreatePostDto>();
            CreateMap<CreatePostDto,Post>();

            //replay
            CreateMap<PostReplay,CreateReplayDto>();
            CreateMap<CreateReplayDto,PostReplay>();

            CreateMap<ShowReplayDto,PostReplay>();
            CreateMap<PostReplay,ShowReplayDto>();
            
         

        }
    }
}