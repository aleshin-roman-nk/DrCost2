using AutoMapper;
using Core.entity;
using Core.repos;
using SQLiteRepo.ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo
{
	public class PaymentCategoryRepoSQLite : IPaymentCategoryRepo
	{
		private readonly AppData db;
		IMapper mapper;

		public PaymentCategoryRepoSQLite(AppData db)
		{
			this.db = db;

			var mapCfg = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<PaymentCategory, PaymentCategoryDb>().ReverseMap();
			});

			mapper = mapCfg.CreateMapper();
		}

		public PaymentCategory Add(PaymentCategory pr)
		{
			throw new NotImplementedException();
		}

		public void Delete(PaymentCategory pr)
		{
			throw new NotImplementedException();
		}

		public PaymentCategory Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<PaymentCategory> GetAll()
		{
			return db.PaymentCategories.Select(x => mapper.Map<PaymentCategory>(x)).ToArray();
		}

		public PaymentCategory Update(PaymentCategory pr)
		{
			throw new NotImplementedException();
		}
	}
}
