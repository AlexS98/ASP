using System.Data.Entity;

namespace MySiteMVC4.Models
{
    public class ReviewContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
    }
}