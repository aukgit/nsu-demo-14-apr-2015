using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace NSUDemo.Models {
    public class EventCategory {
        public int EventCategoryID { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR")]
        [DisplayName("Category Name")]        
        public string EventCategoryName { get; set; }
        [ForeignKey("EventCategoryID")]
        public virtual ICollection<Event> Events { get; set; }

    }
}
