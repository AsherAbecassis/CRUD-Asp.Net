using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int numberOfLikes { get; set; }

        public IEnumerable<PostReplay> replays {get; set;}

    }
}