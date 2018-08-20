using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftScheduler_API.Model
{
    public class Employee_M
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        public string Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public Int16 Active { get; set; }
    }
}
