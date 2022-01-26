using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.PostDto
{
    public class ShowPostsDto
    {
        public IEnumerable<ShowPostDto> showPostsList { get; set; }
        public IEnumerable<ShowReplayDto> showReplaysList { get; set; }
    }
}