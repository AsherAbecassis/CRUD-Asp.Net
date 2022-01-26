using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.PostDto
{
    public class ShowReplaysDto
    {
        public IEnumerable<ShowReplayDto> showReplaysList { get; set; }
    }
}