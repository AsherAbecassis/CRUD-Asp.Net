using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.PostDto
{
    public class ShowPostDto
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int numberOfLikes { get; set; }
        public int replayCount { get => replays.Count(); }
        public IEnumerable<ShowReplayDto> replays {get; set;}
        
        
        
    }
}