using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events.Web.Models
{
    public class UpcomingPassedEventsViewModel
    {
        public IEnumerable<EventsViewModel> UpcomingEvents { get; set; }
        public IEnumerable<EventsViewModel> PassedEvents { get; set; }
    }
}