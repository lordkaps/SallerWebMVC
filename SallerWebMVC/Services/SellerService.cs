using Microsoft.EntityFrameworkCore;
using SallerWebMVC.Data;
using SallerWebMVC.Models;
using SallerWebMVC.Services.Exceptions;
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
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(d => d.Department).FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }

        public void Update(Seller seller)
        { 
            if (!_context.Seller.Any(s => s.Id == seller.Id))
            {
                throw new NotFoundException("Vendedor não encontrado.");
            }
            try
            {
                _context.Update(seller);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
