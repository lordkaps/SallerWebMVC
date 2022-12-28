using Microsoft.EntityFrameworkCore;
using SallerWebMVC.Models;

namespace SallerWebMVC.Data
{
    public class SallerWebMVCContext : DbContext
    {
        public SallerWebMVCContext (DbContextOptions<SallerWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
