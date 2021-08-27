using Microsoft.AspNetCore.Mvc;

namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class IdentityController : ApiBaseController
    {
        [HttpPost("register")] // api/v1/identity/register
        public IActionResult Register()
        {
            return Ok();
        }

        [HttpPost("confirm")] // api/v1/identity/confirm
        public IActionResult Confirm()
        {
            return Ok();
        }

        [HttpPost("login")] // api/v1/identity/login
        public IActionResult Login()
        {
            return Ok();
        }

        [HttpDelete("logout")] // api/v1/identity/logout
        public IActionResult Logout()
        {
            return Ok();
        }

        [HttpGet("sessions")] // api/v1/identity/sessions?options=0
        public IActionResult GetSessions(byte options = 0)
        {
            return Ok();
        }

        [HttpGet("sessions/{id}")] // api/v1/identity/sessions/1
        public IActionResult GetSessionById(long id)
        {
            return Ok();
        }

        [HttpDelete("sessions")] // api/v1/identity/sessions?options=0
        public IActionResult CloseSessions(byte options = 0)
        {
            return Ok();
        }

        [HttpDelete("sessions/{id}")] // api/v1/identity/sessions/1
        public IActionResult CloseSessionById(long id)
        {
            return Ok();
        }
    }
}