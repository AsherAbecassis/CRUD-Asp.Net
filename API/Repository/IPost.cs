using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository
{
    public interface IPost
    {
        Post GetPostById(int id);
        IEnumerable<Post> GetAllPosts();
        Task CreatePost(Post post);
        Task DeletePost(Post post);
        Task DeletePostById(int id);
        Task UpdateContent(int id, string name);
        
    }
}