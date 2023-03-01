
using Microsoft.EntityFrameworkCore;

namespace Frisk_API.Models
{
    public class FriskContext : DbContext
    {
        public DbSet <Comment> Comments { get; set; }

        public FriskContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
