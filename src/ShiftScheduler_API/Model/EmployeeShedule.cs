using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftScheduler_API.Model
{
    public class EmployeeShedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        public DateTime Schedule_Date { get; set; }
        public string Shift_Id { get; set; }
        public string Emp_Id { get; set; }
        [NotMapped]
        public string Emp_Name { get; set; }
    }
}
