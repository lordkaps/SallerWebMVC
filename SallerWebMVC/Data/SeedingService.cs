using Microsoft.EntityFrameworkCore.Internal;
using SallerWebMVC.Models;
using SallerWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SallerWebMVC.Data
{
    public class SeedingService
    {
        private SallerWebMVCContext _context;

        public SeedingService(SallerWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;  // Db já populado.
            }

            ICollection<Department> departaments = new List<Department>
            {
                new Department(1, "Computers"),
                new Department(2, "Electronics"),
                new Department(3, "Fashion"),
                new Department(4, "Books")
            };

            ICollection<Seller> sellers = new List<Seller>
            {
                 new Seller(1, "Lucas", "lucas@gmail.com", new DateTime(1990, 4, 20), 1000.0, departaments.Where(d => d.Id == 1).FirstOrDefault()),
                 new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, departaments.Where(d => d.Id == 2).FirstOrDefault()),
                 new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, departaments.Where(d => d.Id == 1).FirstOrDefault()),
                 new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, departaments.Where(d => d.Id == 4).FirstOrDefault()),
                 new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, departaments.Where(d => d.Id == 3).FirstOrDefault()),
                 new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, departaments.Where(d => d.Id == 2).FirstOrDefault())
            };

            ICollection<SalesRecord> salesRecords = new List<SalesRecord>
            {
                new SalesRecord(1, new DateTime(2021, 09, 25), 11000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 2).FirstOrDefault()),
                new SalesRecord(2, new DateTime(2021, 09, 4), 7000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 5).FirstOrDefault()),
                new SalesRecord(3, new DateTime(2021, 09, 13), 4000.0, SaleStatus.Canceled, sellers.Where(s => s.Id == 4).FirstOrDefault()),
                new SalesRecord(4, new DateTime(2021, 09, 1), 8000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 1).FirstOrDefault()),
                new SalesRecord(5, new DateTime(2021, 09, 21), 3000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 3).FirstOrDefault()),
                new SalesRecord(6, new DateTime(2021, 09, 15), 2000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 1).FirstOrDefault()),
                new SalesRecord(7, new DateTime(2021, 09, 28), 13000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 2).FirstOrDefault()),
                new SalesRecord(8, new DateTime(2021, 09, 11), 4000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 4).FirstOrDefault()),
                new SalesRecord(9, new DateTime(2021, 09, 14), 11000.0, SaleStatus.Pending, sellers.Where(s => s.Id == 6).FirstOrDefault()),
                new SalesRecord(10, new DateTime(2021, 09, 7), 9000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 6).FirstOrDefault()),
                new SalesRecord(11, new DateTime(2021, 09, 13), 6000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 2).FirstOrDefault()),
                new SalesRecord(12, new DateTime(2021, 09, 25), 7000.0, SaleStatus.Pending, sellers.Where(s => s.Id == 3).FirstOrDefault()),
                new SalesRecord(13, new DateTime(2021, 09, 29), 10000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 4).FirstOrDefault()),
                new SalesRecord(14, new DateTime(2021, 09, 4), 3000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 5).FirstOrDefault()),
                new SalesRecord(15, new DateTime(2021, 09, 12), 4000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 1).FirstOrDefault()),
                new SalesRecord(16, new DateTime(2021, 10, 5), 2000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 4).FirstOrDefault()),
                new SalesRecord(17, new DateTime(2021, 10, 1), 12000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 1).FirstOrDefault()),
                new SalesRecord(18, new DateTime(2021, 10, 24), 6000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 3).FirstOrDefault()),
                new SalesRecord(19, new DateTime(2021, 10, 22), 8000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 5).FirstOrDefault()),
                new SalesRecord(20, new DateTime(2021, 10, 15), 8000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 6).FirstOrDefault()),
                new SalesRecord(21, new DateTime(2021, 10, 17), 9000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 2).FirstOrDefault()),
                new SalesRecord(22, new DateTime(2021, 10, 24), 4000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 4).FirstOrDefault()),
                new SalesRecord(23, new DateTime(2021, 10, 19), 11000.0, SaleStatus.Canceled, sellers.Where(s => s.Id == 2).FirstOrDefault()),
                new SalesRecord(24, new DateTime(2021, 10, 12), 8000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 5).FirstOrDefault()),
                new SalesRecord(25, new DateTime(2021, 10, 31), 7000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 3).FirstOrDefault()),
                new SalesRecord(26, new DateTime(2021, 10, 6), 5000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 4).FirstOrDefault()),
                new SalesRecord(27, new DateTime(2021, 10, 13), 9000.0, SaleStatus.Pending, sellers.Where(s => s.Id == 1).FirstOrDefault()),
                new SalesRecord(28, new DateTime(2021, 10, 7), 4000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 3).FirstOrDefault()),
                new SalesRecord(29, new DateTime(2021, 10, 23), 12000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 5).FirstOrDefault()),
                new SalesRecord(30, new DateTime(2021, 10, 12), 5000.0, SaleStatus.Billed, sellers.Where(s => s.Id == 2).FirstOrDefault())
            };


            _context.Department.AddRange(departaments);

            _context.Seller.AddRange(sellers);

            _context.SalesRecord.AddRange(salesRecords);

            _context.SaveChanges();
        }
    }
}
