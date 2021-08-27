using Microsoft.AspNetCore.Mvc;

namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class IdentityController : ApiBaseController
    {
        [HttpPost("register")]
        public IActionResult Register()
        {
            return Ok();
        }

        [HttpPost("confirm")]
        public IActionResult Confirm()
        {
            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            return Ok();
        }

        [HttpDelete("logout")]
        public IActionResult Logout()
        {
            return Ok();
        }

        [HttpGet("sessions")]
        public IActionResult GetSessions(byte option = 0)
        {
            return Ok();
        }

        [HttpGet("sessions/{id}")]
        public IActionResult GetSessionById(long id)
        {
            return Ok();
        }

        [HttpDelete("sessions")]
        public IActionResult CloseSessions(byte option = 0)
        {
            return Ok();
        }

        [HttpDelete("sessions/{id}")]
        public IActionResult CloseSessionById(long id)
        {
            return Ok();
        }
    }
}