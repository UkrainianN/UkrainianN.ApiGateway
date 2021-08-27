using Microsoft.AspNetCore.Mvc;
namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class GroupsController : ApiBaseController
    {
        #region Groups

        [HttpPost] // api/v1/groups
        public IActionResult CreateGroup()
        {
            return Ok();
        }

        [HttpPut("{id}")] // api/v1/groups/1
        public IActionResult UpdateGroup(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")] // api/v1/groups/1
        public IActionResult DeleteGroup(int id)
        {
            return Ok();
        }

        [HttpGet("{id}")] // api/v1/groups/1
        public IActionResult GetGroupById(int id)
        {
            return Ok();
        }

        #endregion

        #region Members

        [HttpPost("{id}/join")] // api/v1/groups/1/join
        public IActionResult JoinToGroup(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}/left")] // api/v1/groups/1/left
        public IActionResult LeftFromGroup(int id)
        {
            return Ok();
        }

        [HttpGet("{id}/members")] // api/v1/groups/1/members?page=1
        public IActionResult GetGroupMembers(int id, int page)
        {
            return Ok();
        }

        [HttpDelete("{id}/members/{memberId}/kick")] // api/v1/groups/1/members/1/kick
        public IActionResult KickMemberFromGroup(int id, int memberId)
        {
            return Ok();
        }

        #endregion

        #region Posts

        [HttpGet("{id}/posts")] // api/v1/groups/1/posts?page=1
        public IActionResult GetGroupFeed(int id, int page)
        {
            return Ok();
        }

        [HttpGet("{id}/posts/{postId}")] // api/v1/groups/1/posts/1
        public IActionResult GetGroupFeedById(int id, long postId)
        {
            return Ok();
        }

        [HttpGet("{id}/posts/{postId}/comments")] // api/v1/groups/1/posts/1/comments
        public IActionResult GetGroupFeedComments(int id, long postId, int page)
        {
            return Ok();
        }

        #endregion

        #region Discussions

        [HttpPost("{id}/discussions")]
        public IActionResult CreateDiscussion()
        {
            return Ok();
        }

        [HttpGet("{id}/discussions")]
        public IActionResult GetDiscussions()
        {
            return Ok();
        }

        [HttpGet("{id}/discussions/{discussionId}")]
        public IActionResult GetDiscussionById(long discussionId)
        {
            return Ok();
        }

        [HttpDelete("{id}/discussions/{discussionId}")]
        public IActionResult DeleteDiscussionById(long discussionId)
        {
            return Ok();
        }

        #endregion
    }
}