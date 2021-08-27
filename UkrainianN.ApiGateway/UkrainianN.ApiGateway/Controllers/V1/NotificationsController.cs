using Microsoft.AspNetCore.Mvc;
using System;

namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class NotificationsController : ApiBaseController
    {
        [HttpGet] // api/v1/notifications?options=0&page=1
        public IActionResult GetUserNotifications(int options = 0, int page = 1)
        {
            return Ok();
        }

        [HttpGet("{id}")] // api/v1/notifications/ef5eb819-ec43-4e8c-b2da-b51d23fd7488
        public IActionResult GetUserNotifications(Guid id)
        {
            return Ok();
        }

        [HttpPost("{id}/read")] // api/v1/notifications/ef5eb819-ec43-4e8c-b2da-b51d23fd7488/read
        public IActionResult ReadNotifications(Guid id)
        {
            return Ok();
        }

        [HttpPost("read")] // api/v1/notifications/read
        public IActionResult ReadAllNotifications()
        {
            return Ok();
        }
    }
}