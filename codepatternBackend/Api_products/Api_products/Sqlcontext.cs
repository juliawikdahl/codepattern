

using Microsoft.EntityFrameworkCore;

namespace Api_products.Models
{
    public class Sqlcontext : DbContext
    {
        public Sqlcontext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<ProductEntity> Products { get; set; }
    }
}
