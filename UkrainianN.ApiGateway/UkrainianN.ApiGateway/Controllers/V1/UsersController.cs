using Microsoft.AspNetCore.Mvc;
namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class UsersController : ApiBaseController
    {
        [HttpGet("{id}")]
        public IActionResult GetUserById()
        {
            return Ok();
        }

        [HttpGet("{id}/posts")]
        public IActionResult GetUserFeed(int id, int page)
        {
            return Ok();
        }

        [HttpGet("{id}/posts/{postId}")]
        public IActionResult GetUserFeed(int id, long postId)
        {
            return Ok();
        }

        [HttpPost("posts")]
        public IActionResult CreateFeed(int id)
        {
            return Ok();
        }
    }
}