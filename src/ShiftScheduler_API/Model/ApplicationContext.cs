using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftScheduler_API.Model
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions opts) :base(opts)
        {
        }

        public DbSet<Employee_M> Employee { get; set; }
        public DbSet<Shift_M> Shift { get; set; }
        public DbSet<EmployeeShedule> EmployeeShedule { get; set; }
        public DbSet<ScheduleDate> ScheduleDate { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
