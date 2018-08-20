using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftScheduler_API.Model
{
    public class ScheduleDate
    {
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(Order =2)]
        public DateTime SchedulingDay { get; set; }
        [Column(Order = 3)]
        public string ShiftID { get; set; }
    }
}
