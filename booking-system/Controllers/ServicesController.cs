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
    public class ServicesController : ControllerBase
    {
        private readonly IServicesService servicesService;

        public ServicesController(IServicesService servicesService)
        {
            this.servicesService = servicesService;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult<List<Services>> Get_all()
        {
            return servicesService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Services> Get(string id)
        {
            var service = servicesService.get(id);

            if (service == null)
            {
                return NotFound($"Service with Id = {id} not found");
            }
            return service;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Services> Post([FromBody]Services service)
        {
            servicesService.create(service);
            return CreatedAtAction(nameof(Get), new { id = service.Id }, service);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var service = servicesService.get(id);

            if (service == null)
            {
                return NotFound($"Service with Id = {id} not found");
            }
            servicesService.remove(id);
            return Ok($"Service with Id = {id} has been deleted");
        }
    }
}

