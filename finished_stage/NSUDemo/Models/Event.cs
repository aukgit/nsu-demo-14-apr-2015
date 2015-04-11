using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NSUDemo.Models {
    public class Event {
        public int EventID { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR")]
        [DisplayName("Event Name")]
        public string EventName { get; set; }

        [StringLength(550)]
        [Column(TypeName = "VARCHAR")]
        public string Description { get; set; }
        public DateTime Dated { get; set; }
        [DisplayName("Category")]

        public int EventCategoryID { get; set; }
      
    }

  
}