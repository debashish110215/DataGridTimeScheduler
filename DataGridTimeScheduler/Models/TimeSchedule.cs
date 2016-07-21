using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataGridTimeScheduler.Models
{
    public class TimeSchedule
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [MaxLength(1)]
        public string StartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan StartSlot { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan EndSlot { get; set; }

        [MaxLength(1)]
        public string EndTime { get; set; }

        [MaxLength(10), Required]
        public string WorkStatus { get; set; }

        public int Duration { get; set; }

        public virtual Employee Employee { get; set; }
    }
}