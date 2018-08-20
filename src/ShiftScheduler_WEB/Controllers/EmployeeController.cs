using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShiftScheduler_WEB.Helper;
using System.Net.Http;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ShiftScheduler_WEB.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeAPI _employeeApi = new EmployeeAPI();
        // GET: /<controller>/
        public async  Task<IActionResult> Index()
        {
            HttpClient client = _employeeApi.InitializeClient();
            HttpResponseMessage res = await client.GetAsync("api/values");
            if(res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;

               
            }
            return View();
        }
    }
}
