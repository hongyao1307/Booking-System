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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService staffService;

        public StaffController(IStaffService staffService)
        {
            this.staffService = staffService;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult<List<Staff>> Get_all()
        {
            return staffService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Staff> Get(string id)
        {
            var staffs = staffService.get(id);

            if (staffs == null)
            {
                return NotFound($"Staffs with Id = {id} not found");
            }
            return staffs;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Staff> Post([FromBody] Staff staff)
        {
            staffService.create(staff);
            return CreatedAtAction(nameof(Get), new { id = staff.Id }, staff);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var staffs = staffService.get(id);

            if (staffs == null)
            {
                return NotFound($"Staffs with Id = {id} not found");
            }
            staffService.remove(id);
            return Ok($"Staffs with Id = {id} has been deleted");
        }
    }
}

