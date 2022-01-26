using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository
{
    public interface IReplay
    {
        PostReplay GetReplayByIdAndPostId(int postId, int replayId);
        IEnumerable<PostReplay> GetAllReplayByPostId(int PostId);
        Task CreateReplayByPostId(PostReplay postReplay, int postId);
        Task DeleteReplayByIdAndPostId(int postId, int replyId);
        Task DeleteAllReplaysByPostId(int postId);
        Task UpdateReplayByIdAndPostId(int replyId, string content,int postId);
        Task AddReplayByPostId(int postId,PostReplay content);
    }
}