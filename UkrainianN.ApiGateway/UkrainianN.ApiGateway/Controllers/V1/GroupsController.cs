using Microsoft.AspNetCore.Mvc;
namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class GroupsController : ApiBaseController
    {
        [HttpPost]
        public IActionResult CreateGroup()
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateGroup(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGroup(int id)
        {
            return Ok();
        }

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

        [HttpGet("{id}/posts")]
        public IActionResult GetGroupFeed(int id, int page)
        {
            return Ok();
        }

        [HttpGet("{id}/posts/{postId}")]
        public IActionResult GetGroupFeedById(int id, long postId)
        {
            return Ok();
        }

        [HttpGet("{id}/posts/{postId}/comments")]
        public IActionResult GetGroupFeedComments(int id, long postId, int page)
        {
            return Ok();
        }
    }
}