using DaNetApi.Domain;
using System;
using System.Collections.Generic;

namespace DaNetApi.Services
{
    public interface IPostService
    {
        List<Post> GetPosts();

        Post GetPostById(Guid postId);

        bool UpdatePost(Post postToUpdate);
      
    }
}
