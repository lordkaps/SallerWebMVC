using SallerWebMVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SallerWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Valor")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }

        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
