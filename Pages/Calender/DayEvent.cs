using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationDemo.Pages.Calender
{
    public class DayEvent
    {
        [Key]
        public int DayEventId { get; set; }
        public string Note { get; set; }
        public DateTime EventDate { get; set; } = new DateTime(1900, 1, 1);
        public DateTime FromDate { get; set; } = new DateTime(1900, 1, 1);
        public DateTime StartDate { get; set; } = new DateTime(1900, 1, 1);
        public string DateValue { get; set; }
        public string DayName { get; set; }
        public string Message { get; set; }
    }
}
