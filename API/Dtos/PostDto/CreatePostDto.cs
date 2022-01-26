using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.PostDto
{
    public class CreatePostDto
    {
       
        public string Content { get; set; }
        public DateTime Created { get; set; }
        
    }
}