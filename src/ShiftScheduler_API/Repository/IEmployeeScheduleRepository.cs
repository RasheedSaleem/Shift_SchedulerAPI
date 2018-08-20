using ShiftScheduler_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftScheduler_API.Repository
{
    public interface IEmployeeScheduleRepository<TEntity, U> where TEntity : class
    {
         IEnumerable<TEntity> GetScheduledList();
         bool CreateSchedule();
    }
}
