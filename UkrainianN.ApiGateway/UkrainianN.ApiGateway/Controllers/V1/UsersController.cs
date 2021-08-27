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
    }
}