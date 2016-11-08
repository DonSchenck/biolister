using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BioLister.Models;

namespace BioLister
{
    [Route("bios")]
    public class BiosController : Controller
    {
        [HttpGet("userid/{userId}")]
        public IEnumerable<Bio> UserId(string userId)
        {
           var db = new BioContext();
           var bio = db.Bio.Where(p => p.UserId == userId);
            if (bio == null)
            {
                // TODO return error
            }
           return  bio.ToList();
        }
        [HttpGet("id/{id}")]
        public IActionResult Id(int id)
        {
            var db = new BioContext();
            var bio = db.Bio.FirstOrDefault(p => p.Id == id);
            if (bio == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(bio);
        }
    }
}