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
	public class CurrencyRepoSQLite : ICurrencyRepo
	{
		private readonly AppData db;
		IMapper mapper;

		public CurrencyRepoSQLite(AppData db)
		{
			this.db = db;

			var mapCfg = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Currency, CurrencyDb>().ReverseMap();
			});

			mapper = mapCfg.CreateMapper();
		}
		public Currency Add(Currency pr)
		{
			throw new NotImplementedException();
		}

		public void Delete(Currency pr)
		{
			throw new NotImplementedException();
		}

		public Currency Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Currency> GetAll()
		{
			return db.Currencies.Select(x => mapper.Map<Currency>(x)).ToArray();
		}

		public Currency Update(Currency pr)
		{
			throw new NotImplementedException();
		}
	}
}
