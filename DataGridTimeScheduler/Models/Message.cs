using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataGridTimeScheduler.Models
{
    public class Message
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Give the Message a Title")]
        [MaxLength(50, ErrorMessage = "Please Type the Message Title in max {50} characters")]
        [Display(Name = "Message Title")]
        public string MessageTitle { get; set; }

        [Required]
        public int SenderID { get; set; }

        [Required]
        public int ReceiverID { get; set; }

        [MaxLength(200, ErrorMessage = "Please Type the Message in Short max {200} characters"), Required]
        [Display(Name = "Message Body")]
        public string MessageBody { get; set; }

        [Required]
        public bool IsSeen { get; set; }

        public virtual Employee Employee { get; set; }
    }
}