using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusDetailsSystem.Data;
using BusDetailsSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusDetailsSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public BusDetailsController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet("{travel}")]
        public ActionResult<IEnumerable<BusDetail>> GetBusDtlsByOrgDest(string travel)
        {
            var res = _db.BusDetails?.ToList().FindAll(item => item.Origin == travel.Split("2")[0] && item.Destination == travel.Split("2")[1]);

            return Ok(res);
        }

        [HttpPost]
        public ActionResult<string> PostABusDetail([FromBody] BusDetail newBusDtl)
        {
            _db.BusDetails?.Add(newBusDtl);
            _db.SaveChanges();

            return Ok("A Bus Detail posted successfully");
        }

        [HttpPut("{id}")]
        public ActionResult<string> DoVote(int id, [FromBody] int vote)
        {
            if (_db.BusDetails?.Find(id) == null)
            {
                return BadRequest("invalid id");
            }

            _db.BusDetails?.Find(id)?.doVote(vote);
            _db.SaveChanges();

            return Ok(vote == 1 ? "Upvoted" : "downVoted");
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteABusDetail(int id)
        {
            var itemToDelete = _db.BusDetails?.Find(id);

            if (itemToDelete == null)
            {
                return BadRequest("invalid id");
            }
 
            _db.BusDetails?.Remove(itemToDelete);
            _db.SaveChanges();

            return Ok("Deleted succesfully");
        }

    }
}