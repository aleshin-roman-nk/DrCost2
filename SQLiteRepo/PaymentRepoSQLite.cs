using AutoMapper;
using Core.entity;
using Core.repos;
using Microsoft.EntityFrameworkCore;
using SQLiteRepo.ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo
{
	public class PaymentRepoSQLite : IPaymentRepo
	{
		private readonly AppData db;

		IMapper mapper;

		public PaymentRepoSQLite(AppData db)
		{
			this.db = db;

			var mapCfg = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Payment, PaymentDb>().ReverseMap();
			});

			mapper = mapCfg.CreateMapper();
		}

		public Payment Add(Payment pr)
		{
			var savePr = mapper.Map<PaymentDb>(pr);

			db.Payments.Add(savePr);

			db.SaveChanges();

			return mapper.Map<Payment>(savePr);
		}

		public void Delete(Payment pr)
		{
			db.Payments.Remove(new ent.PaymentDb { id = pr.id});
		}

		public IEnumerable<Payment> Get(int year, int month)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Payment> Get(DateTime dtFrom, DateTime dtTo)
		{
			var query = from payment in db.Payments
						where payment.Date >= dtFrom && payment.Date <= dtTo
						join category in db.PaymentCategories
						on payment.categoryId equals category.id
						select new Payment
						{
							id = payment.id,
							name = payment.name,
							categoryName = category.name,
							count = payment.count,
							Date = payment.Date,
							price = payment.price
						};

			return query.ToArray();

			//return db.Products.Where(x => x.Date >= dtFrom && x.Date <= dtTo).Select(x => mapper.Map<Product>(x))
			//	.ToArray();
		}

		public Payment Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Payment> GetAll()
		{
			throw new NotImplementedException();
		}

		public decimal GetTotalSpend()
		{
			throw new NotImplementedException();
		}

		public Payment Update(Payment pr)
		{
			throw new NotImplementedException();
		}
	}
}
