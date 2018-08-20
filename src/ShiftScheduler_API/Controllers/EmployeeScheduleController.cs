using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShiftScheduler_API.Repository;
using ShiftScheduler_API.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ShiftScheduler_API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeScheduleController : Controller
    {
        private IEmployeeScheduleRepository<EmployeeShedule, string> _iRepo;
        public EmployeeScheduleController(IEmployeeScheduleRepository<EmployeeShedule, string> repo)
        {
            _iRepo = repo;
        }
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _iRepo.GetScheduledList();
                if(result.Count() > 0)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound("No Data Found");
                }
            }
            catch(Exception ex)
            {
                return BadRequest("Something Went wrong");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }



        // POST api/values
        [HttpPost]
        public IActionResult Post()
        {
            if(_iRepo.CreateSchedule())
            {
                return Ok("Schedule Succeed");
            }
            else
            {
                return BadRequest("Schedule Fails!");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
