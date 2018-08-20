using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShiftScheduler_API.Repository;
using ShiftScheduler_API.Model;
using System.Net.Http;
using System.Net;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ShiftScheduler_API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeRepository<Employee_M, string> _iRepo;
        public EmployeeController(IEmployeeRepository<Employee_M, string> repo)
        {
            _iRepo = repo;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Employee_M> GetAllEmployee()
        {
            return _iRepo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(string id)
        {
            try
            {
                var emp = _iRepo.GetById(id);
                if (emp != null)
                {
                    return Ok(emp);
                }
                else
                {
                    return NotFound($"Employee of ID {id} Not Found");
                }
            }
            catch(Exception ex)
            {
                return BadRequest("Something Went wrong");
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
