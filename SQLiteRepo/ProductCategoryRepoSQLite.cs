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
	public class ProductCategoryRepoSQLite : ICategoryRepo
	{
		private readonly AppData db;
		IMapper mapper;

		public ProductCategoryRepoSQLite(AppData db)
		{
			this.db = db;

			var mapCfg = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<ProductCategory, ProductCategoryDb>().ReverseMap();
			});

			mapper = mapCfg.CreateMapper();
		}

		public ProductCategory Add(ProductCategory pr)
		{
			throw new NotImplementedException();
		}

		public void Delete(ProductCategory pr)
		{
			throw new NotImplementedException();
		}

		public ProductCategory Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ProductCategory> GetAll()
		{
			return db.ProductCategories.Select(x => mapper.Map<ProductCategory>(x)).ToArray();
		}

		public ProductCategory Update(ProductCategory pr)
		{
			throw new NotImplementedException();
		}
	}
}
