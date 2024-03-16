using Core.CashReceipts;
using Core.CashReceipts.dto;
using Core.entity;
using Microsoft.EntityFrameworkCore;
using SQLiteRepo.ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.CashReceipts
{
	public class CashReceiptRepoSQLite : ICashReceiptRepo
	{
		private readonly AppData db;

		public CashReceiptRepoSQLite(AppData db)
		{
			this.db = db;
		}

		public CashReceipt Create(CreateCashReceiptDto dto)
		{
			CashReceiptDb cashReceiptToCreateDb = new CashReceiptDb
			{
				Date = dto.Date,
				shop = dto.shop
			};

			cashReceiptToCreateDb.Payments = new List<PaymentDb>();

			foreach (var crp in dto.CreatePaymentDtos)
			{
				cashReceiptToCreateDb.Payments.Add(new PaymentDb
				{
					budgetId = crp.budgetId,
					categoryId = crp.categoryId,
					count = crp.count,
					Date = crp.Date,
					name = crp.name,
					price = crp.price,
					paymentSampleId = crp.paymentSampleId,
					cashReceiptId = cashReceiptToCreateDb.id
				});
			}

			db.CashReceipts.Add(cashReceiptToCreateDb);

			db.SaveChanges();

			var res = new CashReceipt
			{
				Date = cashReceiptToCreateDb.Date,
				id = cashReceiptToCreateDb.id,
				shop = cashReceiptToCreateDb.shop
			};

			res.Payments = db.Payments
				.Include(p => p.category)
				.Where(p => p.cashReceiptId == cashReceiptToCreateDb.id)
				.Select(p => new Payment
				{
					categoryName = p.category.name,
					count = p.count,
					Date = p.Date,
					name = p.name,
					price = p.price,
					id = p.id
				})
				.ToArray();

			return res;
		}

		public IEnumerable<CashReceipt> GetAll(int year, int month)
		{
			DateTime dtFrom = new DateTime(year, month, 1, 0, 0, 0);
			DateTime dtTo = dtFrom.AddMonths(1);

			return db.CashReceipts
				.Include(cr => cr.Payments)
				.ThenInclude(p => p.category)
				.Where(cr => cr.Date >= dtFrom && cr.Date < dtTo)
				.Select(cr => new CashReceipt
				{
					Date = cr.Date,
					id = cr.id,
					shop = cr.shop,
					Payments = cr.Payments
							.Select(p => new Payment
							{
								categoryName = p.category.name,
								name = p.name,
								count = p.count,
								Date = p.Date,
								id = p.id,
								price = p.price
							})
				})
				.ToArray();
		}
	}
}
