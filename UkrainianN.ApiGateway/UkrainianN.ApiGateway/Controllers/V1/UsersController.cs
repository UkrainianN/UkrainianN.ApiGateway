using Microsoft.AspNetCore.Mvc;
namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class UsersController : ApiBaseController
    {
        [HttpGet("{id}")] // api/v1/users/1
        public IActionResult GetUserById(int id)
        {
            return Ok();
        }

        [HttpGet("{id}/posts")] // api/v1/users/1/posts?page=1
        public IActionResult GetUserPosts(int id, int page)
        {
            return Ok();
        }

        [HttpGet("{id}/posts/{postId}")] // api/v1/users/1/posts/1
        public IActionResult GetUserPosts(int id, long postId)
        {
            return Ok();
        }

        [HttpPost("posts")] // api/v1/users/posts
        public IActionResult CreatePost()
        {
            return Ok();
        }
    }
}