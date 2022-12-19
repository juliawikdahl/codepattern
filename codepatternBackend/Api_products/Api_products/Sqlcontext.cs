

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

    // dependency-inversion-principle, har gjort depency injection. 
}
