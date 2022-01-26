using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.PostDto
{
    public class ShowReplayDto
    {
        public int PostReplayId { get; set; }   
        public string Content { get; set; }
        public DateTime Create { get; set; }
        
        
    }
}