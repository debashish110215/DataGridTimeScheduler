using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataGridTimeScheduler.Models
{
    public class TimeScheduleType
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(1, ErrorMessage = "Working Hour must be {0} to {9} hour"), MinLength(1)]
        [Required(ErrorMessage = "Working Required")]
        public int Threashold { get; set; }

        [Required(ErrorMessage = "StartTime Required")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "EndTime Required")]
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }

        public bool IsSetThreshold { get; set; }

        public bool IsSetDuration { get; set; }

    }
}