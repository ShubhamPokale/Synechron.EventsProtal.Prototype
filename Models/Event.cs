using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace Synechron.EventsPortal.Models
{
    public class Event
    {

        public int EventId { get; set; }

        public string EventCode { get; set; }

        public string EventName { get; set; }

        public string EventDescirption { get; set; }


        public DateTime EventStartDate  { get; set; }

        public DateTime EventEndDate { get; set; }

        public double EventFees { get; set; }


        public int EventTotalSeatsFilled { get; set; }

        public string EventLogo { get; set; }

    }
}