using SallerWebMVC.Data;
using SallerWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SallerWebMVC.Services
{
    public class SellerService
    {
        private readonly SallerWebMVCContext _context;

        public SellerService(SallerWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
