﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DaNetApi.Contracts.V1;
using DaNetApi.Models;
using DaNetApi.Contracts.V1.Requests;
using DaNetApi.Contracts.V1.Responses;
using DaNetApi.Services;
using System.Threading.Tasks;

namespace DaNetApi.Controllers.V1
{
    public class PostsController : Controller
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _postService.GetPostsAsync());
        }

        [HttpPut(ApiRoutes.Posts.Update)]
        public async Task<IActionResult> Update([FromRoute]Guid postId, [FromBody] UpdatePostRequest request)
        {
            var post = new Post
            {
                Id = postId,
                Title = request.Title,
                SubTitle = request.SubTitle,
                Slug = request.Slug,
                BodyText = request.BodyText
            };

            var updated = await _postService.UpdatePostAsync(post);

            if(updated)
              return Ok(post);

            return NotFound();
        }

        [HttpDelete(ApiRoutes.Posts.Delete)]
        public async Task<IActionResult> Delete([FromRoute]Guid postId)
        {
            var deleted = await _postService.DeletePostAsync(postId);

            if (deleted)
                return NoContent();

            return NotFound();
        }

        [HttpGet(ApiRoutes.Posts.Get)]
        public async Task<IActionResult> Get([FromRoute]Guid postId)
        {
            var post = await _postService.GetPostByIdAsync(postId);

            if (post == null)
                return NotFound();

            return Ok(post);
        }


        [HttpPost(ApiRoutes.Posts.Create)]
        public async Task<IActionResult> Create([FromBody] CreatePostRequest postRequest)
        {
            var post = new Post { Title = postRequest.Title };

            await _postService.CreatePostAsync(post);

            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + ApiRoutes.Posts.Get.Replace("{postId}", post.Id.ToString());

            var response = new PostResponse { Id = post.Id };
            return Created(locationUri, response);
        }
    }
}