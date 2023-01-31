using Microsoft.EntityFrameworkCore;
using SallerWebMVC.Data;
using SallerWebMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallerWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SallerWebMVCContext _context;

        public DepartmentService(SallerWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
