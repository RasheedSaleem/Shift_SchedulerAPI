using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftScheduler_API.Model
{
    public class Shift_M
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        public string Shift_Id { get; set; }
        public string Shift_Desc { get; set; }
    }
}
