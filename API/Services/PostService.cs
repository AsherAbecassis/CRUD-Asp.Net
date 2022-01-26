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
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _db;

        public PostService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task CreatePost(Post post)
        {
            
            await _db.Posts.AddAsync(post);
            await _db.SaveChangesAsync();

        }

        public Task DeletePost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task DeletePostById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _db.Posts.Include(p => p.replays);
        }

        public Post GetPostById(int id)
        {
            return _db.Posts.FirstOrDefault(i => i.PostId ==id);
        }

        public Task UpdateContent(int id, string name)
        {
            throw new NotImplementedException();
        }
        
    }
}