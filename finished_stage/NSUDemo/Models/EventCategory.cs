using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace NSUDemo.Models {
    public class EventCategory {
    
        public int EventCategoryId { get; set; }
        public string EventCategoryName { get; set; }
    }
}
