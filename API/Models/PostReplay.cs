using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PostReplay
    {
        public int PostReplayId { get; set; }   
        public string Content { get; set; }
        
        public DateTime Create { get; set; }
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        

    }
}