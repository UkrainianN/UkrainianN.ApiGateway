using Microsoft.AspNetCore.Mvc;
namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class GroupsController : ApiBaseController
    {
        [HttpGet("{id}")]
        public IActionResult GetGroupById(int id)
        {
            return Ok();
        }

        [HttpPost("{id}/join")]
        public IActionResult JoinToGroup(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}/left")]
        public IActionResult LeftFromGroup(int id)
        {
            return Ok();
        }

        [HttpGet("{id}/members")]
        public IActionResult GetGroupMembers(int id, int page)
        {
            return Ok();
        }

        [HttpDelete("{id}/members/{memberId}/kick")]
        public IActionResult KickMemberFromGroup(int id, int memberId)
        {
            return Ok();
        }

        [HttpGet("{id}/feed")]
        public IActionResult GetGroupFeed(int id, int page)
        {
            return Ok();
        }

        [HttpGet("{id}/feed/{feedId}")]
        public IActionResult GetGroupFeedById(int id, long feedId)
        {
            return Ok();
        }

        [HttpGet("{id}/feed/{feedId}/comments")]
        public IActionResult GetGroupFeedComments(int id, long feedId, int page)
        {
            return Ok();
        }
    }
}