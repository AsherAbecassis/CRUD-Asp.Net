using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using API.Repository;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class ReplyService : IReplay
    {
        private readonly ApplicationDbContext _db;

        public ReplyService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddReplayByPostId(int postId, PostReplay content)
        {
            
            content.PostId = postId;
            System.Console.WriteLine("++++++++++{0}+++++++++++++++",content.Content);
            await _db.PostReplays.AddAsync(content);
            await _db.SaveChangesAsync();
        }

        public Task CreateReplayByPostId(PostReplay postReplay, int postId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAllReplaysByPostId(int postId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReplayByIdAndPostId(int postId, int replyId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostReplay> GetAllReplayByPostId(int PostId)
        {
            var model = _db.PostReplays
            .Where(p => p.PostId == PostId);
            
            
            return model;
        }

        public PostReplay GetReplayByIdAndPostId(int postId, int replayId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReplayByIdAndPostId(int replyId, string content, int postId)
        {
            throw new NotImplementedException();
        }
    }
}