using System;
using System.Collections.Generic;
using System.Linq;
using DaNetApi.Domain;

namespace DaNetApi.Services
{
    public class postService : IPostService
    {
        private readonly List<Post> _posts;

        public postService()
        {
            _posts = new List<Post>();
            for (var i = 0; i < 5; i++)
            {
                _posts.Add(new Post
                {
                    Id = Guid.NewGuid(),
                    Title = $"Post Title { i}"
                });
            }
        }

        public Post GetPostById(Guid postId)
        {
            return _posts.SingleOrDefault(x => x.Id == postId);
        }

        public List<Post> GetPosts()
        {
            return _posts;
        }
    }
}
