using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booking_system.service;
using booking_system.models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace booking_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private readonly IGuestsService guestsService;

        public GuestsController(IGuestsService guestsService)
        {
            this.guestsService = guestsService;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult<List<Guests>> Get_all()
        {
            return guestsService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Guests> get(string id)
        {
            var guest = guestsService.get(id);

            if (guest == null)
            {
                return NotFound($"Guest with Id = {id} not found");
            }
            return guest;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Guests> Post([FromBody] Guests guest)
        {
            guestsService.create(guest);
            return CreatedAtAction(nameof(get), new { id = guest.Id }, guest);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody]Guests guest)
        {
            var existing_guest = guestsService.get(id);
            if (existing_guest == null)
            {
                return NotFound($"Guest with Id = {id} not found");
            }
            guestsService.update(id, guest);
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var existing_guest = guestsService.get(id);
            if (existing_guest == null)
            {
                return NotFound($"Guest with Id = {id} not found");
            }
            guestsService.remove(existing_guest.Id);
            return Ok($"Guest with Id = {id} has been deleted");
        }
    }
}

