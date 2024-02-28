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
	public class ProductNameRepoSqlite : IProductNameRepo
	{
		private readonly AppData db;
		IMapper mapper;

		public ProductNameRepoSqlite(AppData db)
		{
			this.db = db;

			var mapCfg = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<ProductName, ProductNameDb>().ReverseMap();
			});

			mapper = mapCfg.CreateMapper();
		}

		public ProductName Add(ProductName pr)
		{
			var pNameDb = mapper.Map<ProductNameDb>(pr);

			db.ProductNames.Add(pNameDb);
			db.SaveChanges();

			return mapper.Map<ProductName>(pNameDb);
		}

		public void Delete(ProductName pr)
		{
			throw new NotImplementedException();
		}

		public ProductName Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ProductName> GetAll()
		{
			return db.ProductNames.Select(x => mapper.Map<ProductName>(x)).ToArray();
		}

		public ProductName Update(ProductName pr)
		{
			var prDb = mapper.Map<ProductNameDb>(pr);

			db.ProductNames.Attach(prDb);

			db.Entry(prDb).State = EntityState.Modified;

			db.SaveChanges();

			return mapper.Map<ProductName>(prDb);
		}
	}
}
