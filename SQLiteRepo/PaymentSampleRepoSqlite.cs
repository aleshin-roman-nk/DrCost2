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
	public class PaymentSampleRepoSqlite : IPaymentSampleRepo
	{
		private readonly AppData db;
		IMapper mapper;

		public PaymentSampleRepoSqlite(AppData db)
		{
			this.db = db;

			var mapCfg = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<PaymentSample, PaymentSampleDb>().ReverseMap();
			});

			mapper = mapCfg.CreateMapper();
		}

		public PaymentSample Add(PaymentSample pr)
		{
			var pNameDb = mapper.Map<PaymentSampleDb>(pr);

			db.PaymentSamples.Add(pNameDb);
			db.SaveChanges();

			return mapper.Map<PaymentSample>(pNameDb);
		}

		public void Delete(PaymentSample pr)
		{
			throw new NotImplementedException();
		}

		public PaymentSample Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<PaymentSample> GetAll()
		{
			return db.PaymentSamples
				.Include(x => x.findingTag)
				.Include(x => x.category)
				.Select(x => mapper.Map<PaymentSample>(x)).ToArray();
		}

		public PaymentSample Update(PaymentSample pr)
		{
			var prDb = mapper.Map<PaymentSampleDb>(pr);

			db.PaymentSamples.Attach(prDb);

			db.Entry(prDb).State = EntityState.Modified;

			db.SaveChanges();

			return mapper.Map<PaymentSample>(prDb);
		}
	}
}
