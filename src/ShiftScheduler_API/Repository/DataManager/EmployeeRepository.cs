using ShiftScheduler_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftScheduler_API.Repository.DataManager
{
    public class EmployeeRepository : IEmployeeRepository<Employee_M, string>
    {
        ApplicationContext ctx;
        public EmployeeRepository(ApplicationContext c)
        {
            ctx = c;
        }
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee_M> GetAll()
        {
            return ctx.Employee.ToList();
        }

        public Employee_M GetById(string id)
        {
            return ctx.Employee.FirstOrDefault(a=>a.Emp_ID==id);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
