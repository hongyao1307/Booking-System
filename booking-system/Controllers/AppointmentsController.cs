using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booking_system.models;
using booking_system.service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace booking_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentsService appointmentsService;
        private readonly IStaffService staffService;

        public AppointmentsController(IAppointmentsService appointmentsService, IStaffService staffService)
        {
            this.appointmentsService = appointmentsService;
            this.staffService = staffService;
        }
        // GET: api/values

        [HttpGet("{booking_date:DateTime}")]
        public ActionResult<List<Appointments>> Get_all(DateTime booking_date)
        {
            return appointmentsService.Get(booking_date);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Appointments> Get(string id)
        {
            var appointment = appointmentsService.get(id);
            if (appointment == null)
            {
                return NotFound($"Appointment with Id = {id} not found");
            }
            return appointment;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Appointments> Post([FromBody]Appointments appointment)
        {
            appointmentsService.create(appointment);
            return CreatedAtAction(nameof(Get), new { id = appointment.Id }, appointment);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody]Appointments appointment)
        {
            var existing_appointment = appointmentsService.get(id);

            if (existing_appointment == null)
            {
                return NotFound($"Appointment with Id = {id} not found");
            }
            appointmentsService.update(id, appointment);
            return NoContent();
        }

        [HttpGet]
        public ActionResult<List<Staff>> Get_staff(DateTime booking_date, String booking_time)
        {
            List<Staff> staff = staffService.Get();

            List<Appointments> appointment = appointmentsService.choose_existstaffs_id(booking_date, booking_time);

            List<string> existing_ids = new List<string>();
            List<Staff> available_staff = new List<Staff>();

            appointment.ForEach(x =>
            {
                existing_ids.Add(x.StaffsId);
            });

            staff.ForEach(x =>
            {   
                if (!existing_ids.Contains(x.Id))
                {
                    available_staff.Add(x);
                }
            });

            return available_staff;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var existing_appointment = appointmentsService.get(id);

            if (existing_appointment == null)
            {
                return NotFound($"Appointment with Id = {id} not found");
            }
            appointmentsService.remove(existing_appointment.Id);
            return Ok($"Appointment with Id = {id} has been deleted");
        }
    }
}

