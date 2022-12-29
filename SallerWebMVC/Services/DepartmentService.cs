using SallerWebMVC.Data;
using SallerWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SallerWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SallerWebMVCContext _context;

        public DepartmentService(SallerWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
