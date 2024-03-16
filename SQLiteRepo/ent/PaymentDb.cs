using Core.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.ent
{
    [Table("Payments")]
    public class PaymentDb
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public int budgetId { get; set; }
        public string? name { get; set; }
        public decimal price { get; set; }
        public decimal count { get; set; }
        public DateTime Date { get; set; }
        //public PaymentCategoryDb category { get; set; }
        public PaymentCategory? category { get; set; }
        public int paymentSampleId { get; set; }
		public int? cashReceiptId { get; set; }
	}
}
