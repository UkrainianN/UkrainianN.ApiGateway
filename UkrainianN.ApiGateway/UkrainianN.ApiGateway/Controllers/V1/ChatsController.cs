using Microsoft.AspNetCore.Mvc;

namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class ChatsController : ApiBaseController
    {
        [HttpPost] // api/v1/chats
        public IActionResult CreateChat()
        {
            return Ok();
        }

        [HttpPut("{id}")] // api/v1/chats/1
        public IActionResult UpdateChat(long id)
        {
            return Ok();
        }

        [HttpDelete("{id}")] // api/v1/chats/1
        public IActionResult DeleteChat(long id)
        {
            return Ok();
        }

        [HttpGet] // api/v1/chats
        public IActionResult GetMyChats()
        {
            return Ok();
        }

        [HttpGet("{id}")] // api/v1/chats/1
        public IActionResult GetChatById(long id)
        {
            return Ok();
        }

        [HttpGet("{id}/messages")] // api/v1/chats/1/messages
        public IActionResult GetChatMessages(long id, int page)
        {
            return Ok();
        }

        [HttpPost("messages")] // api/v1/chats/messages
        public IActionResult SendMessaage()
        {
            return Ok();
        }

        [HttpPut("message/{id}")] // api/v1/chats/messages/1
        public IActionResult UpdateMessaage(long id)
        {
            return Ok();
        }

        [HttpDelete("message/{id}")] // api/v1/chats/messages/1
        public IActionResult RemoveMessaage(long id)
        {
            return Ok();
        }
    }
}