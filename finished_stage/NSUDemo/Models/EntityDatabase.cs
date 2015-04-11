using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NSUDemo.Models {
    public class EntityDatabase: DbContext {

        public EntityDatabase() // {
            : base("EventConnection") {
            
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
    }
}