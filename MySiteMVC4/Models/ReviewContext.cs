using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MySiteMVC4.Models
{
    public class ReviewContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
    }
}