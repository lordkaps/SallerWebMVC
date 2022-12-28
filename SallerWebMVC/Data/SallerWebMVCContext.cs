using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<SallerWebMVC.Models.Department> Department { get; set; }
    }
}
