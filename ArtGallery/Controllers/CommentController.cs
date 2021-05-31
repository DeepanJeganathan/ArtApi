using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGallery.Models;
using ArtGallery.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtGallery.Controllers
{
    [Route("api/Comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IComment _comment;

        public CommentController(IComment comment)
        {
            this._comment = comment;
        }

        // GET: api/Comment
        [HttpGet]
        public ActionResult<List<Comment>> Get()
        {
            return _comment.GetAll();
        }

        // GET: api/Comment/5
        [HttpGet("{artId}")]
        public ActionResult<List<Comment>> Get(int artId)
        {
            return _comment.Get(artId);
        }

        // POST: api/Comment
        [HttpPost]
        public ActionResult create([FromForm] Comment comment)
        {
            if (comment == null)
            {
                return BadRequest(ModelState);
            }
            comment.Date = DateTime.Now;

            if (!_comment.CreateComment(comment))
            {
                ModelState.AddModelError("", " error in saving comment");
                return StatusCode(500, ModelState);
            }
            return CreatedAtAction(nameof(Get), new { id = comment.CommentId }, comment);
        }

     

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_comment.CommentExists(id))
            {
                return NotFound();
            }
            var comment = _comment.GetById(id);

            if (!_comment.DeleteComment(comment))
            {

                ModelState.AddModelError("", "error in deleting comment");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }
    }
}
