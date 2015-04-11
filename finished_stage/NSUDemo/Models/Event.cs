using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NSUDemo.Models {
    public class Event {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime Dated { get; set; }
        public int EventCategoryId { get; set; }

        [ForeignKey("EventCategoryId")]
        public virtual ICollection<EventCategory> EventCategories  { get; set; }

    }

  
}