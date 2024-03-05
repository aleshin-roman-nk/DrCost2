using AutoMapper;
using Core.dto;
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

		public PaymentSample Add(CreatePaymentSampleDto sampleDto)
		{
			var toCreate = new PaymentSampleDb
			{
				categoryId = sampleDto.categoryId,
				name = sampleDto.name,
				findingTagId = sampleDto.tagId
			};

			db.PaymentSamples.Add(toCreate);
			db.SaveChanges();

			var createdEnt = db.PaymentSamples
				.Include(p => p.findingTag)
				.Include(p => p.category)
				.FirstOrDefault(ps => ps.id == toCreate.id);

			return new PaymentSample
			{
				id = toCreate.id,
				name = toCreate.name,
				category = new PaymentCategory { id = createdEnt.category.id, name = createdEnt.category.name },
				findingTag = new FindingTag { id = createdEnt.findingTag.id, name = createdEnt.findingTag.name },
			};
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
				.Select(x => new PaymentSample
				{
					category = new PaymentCategory { id = x.category.id, name = x.category.name},
					findingTag = new FindingTag { id = x.findingTag.id, name = x.findingTag.name },
					id = x.id,
					name = x.name
				})
				.ToArray();
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
