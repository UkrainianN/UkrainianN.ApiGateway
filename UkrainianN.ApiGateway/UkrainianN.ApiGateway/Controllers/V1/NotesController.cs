using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UkrainianN.ApiGateway.Controllers.V1
{
    public class NotesController : ApiBaseController
    {
        [HttpPost] // api/v1/notes
        public IActionResult CreateNote()
        {
            return Ok();
        }

        [HttpPut("{id}")] // api/v1/notes/1
        public IActionResult UpdateNote(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")] // api/v1/notes/1
        public IActionResult DeleteNote(int id)
        {
            return Ok();
        }

        [HttpGet] // api/v1/notes?userId=1
        public IActionResult GetUserNotes(int userId = 0)
        {
            return Ok();
        }

        [HttpGet("{id}")] // api/v1/notes/1
        public IActionResult GetNoteById(int id)
        {
            return Ok();
        }
    }
}
