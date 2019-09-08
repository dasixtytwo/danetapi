using DaNetApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DaNetApi.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPostsAsync();

        Task<bool> CreatePostAsync(Post post);

        Task<Post> GetPostByIdAsync(Guid postId);

        Task <bool> UpdatePostAsync(Post postToUpdate);

        Task <bool> DeletePostAsync(Guid postId);
    }
}
