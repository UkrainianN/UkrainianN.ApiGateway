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

        [HttpGet("{id}/feed")]
        public IActionResult GetUserFeed(int id, int page)
        {
            return Ok();
        }

        [HttpPost("feed")]
        public IActionResult CreateFeed()
        {
            return Ok();
        }
    }
}