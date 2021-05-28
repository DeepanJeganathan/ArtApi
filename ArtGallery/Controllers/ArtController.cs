using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGallery.Data;
using ArtGallery.Models;
using ArtGallery.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtGallery.Controllers
{
    [Route("api/Art")]
    [ApiController]
    public class ArtController : ControllerBase
    {
        private readonly IArt _art;

        public ArtController(IArt art)
        {
            this._art = art;
        }
        // GET: api/Art
        [HttpGet]
        public ActionResult<IList<ArtModel>> Get([FromQuery] ArtParameters artParameters, string search )
        {
           
            return _art.GetAll(artParameters,search).ToList();
        }

        [HttpGet("total")]
        public  ActionResult<int> GetTotalItems()
        {

            return _art.Count();
        }
        // GET: api/Art/5
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return "value";
        }

        // POST: api/Art
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Art/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
