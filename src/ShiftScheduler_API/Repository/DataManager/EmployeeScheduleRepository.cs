using ShiftScheduler_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading .Tasks;

namespace ShiftScheduler_API.Repository.DataManager
{
    public class EmployeeScheduleRepository : IEmployeeScheduleRepository<EmployeeShedule, string>
    {
        ApplicationContext ctx;
        public EmployeeScheduleRepository(ApplicationContext c)
        {
            ctx = c;
        }
        public bool CreateSchedule()
        {
            int NumberOfDays = 10;
            var lstshift = (ctx.Shift).Select(a => a.Shift_Id).ToList();
            List<EmployeeShedule> lstempSch = new List<EmployeeShedule>();
            List<DateTime> lstDate = General.GetScheduleDate(NumberOfDays);
            foreach(var item_S in lstshift)
            {
                foreach(var item_D in lstDate)
                {

                    var TotempList = (from c in ctx.Employee where !lstempSch.Any(es => (es.Emp_Id == c.Emp_ID) && ((es.Schedule_Date.ToString("dd/MM/yyyy") == item_D.ToString("dd/MM/yyyy"))))
                               select c).ToList();

                    var EmpList = (from e in TotempList where
                                   !lstempSch.Any(ess =>(ess.Emp_Id ==e.Emp_ID) && (ess.Schedule_Date.ToString("dd/MM/yyyy") == item_D.AddDays(-1).ToString("dd/MM/yyyy")) && (ess.Shift_Id == item_S))
                                   select e.Emp_ID).OrderBy(o=>Guid.NewGuid()).Take(2).ToList();

                
                    if (EmpList.Count > 0)
                    {
                        foreach(var item in EmpList)
                        {
                            EmployeeShedule empSch = new EmployeeShedule();
                            empSch.Emp_Id = item;
                            empSch.Schedule_Date = item_D;
                            empSch.Shift_Id = item_S;
                            lstempSch.Add(empSch);
                        }
                    }
                }
            }
            ctx.EmployeeShedule.AddRange(lstempSch);
            ctx.SaveChanges();
            return true;
        }

        public IEnumerable<EmployeeShedule> GetScheduledList()
        {
            var result=ctx.EmployeeShedule.OrderBy(o=>o.Schedule_Date).ToList();

            result.ForEach(a=>a.Emp_Name=(from pp in ctx.Employee where pp.Emp_ID==a.Emp_Id select pp.Emp_Name).FirstOrDefault());
            return result;
        }
    }
}
