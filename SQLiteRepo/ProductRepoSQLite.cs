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
	public class ProductRepoSQLite : IProductRepo
	{
		private readonly AppData db;

		IMapper mapper;

		public ProductRepoSQLite(AppData db)
		{
			this.db = db;

			var mapCfg = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Product, ProductDb>().ReverseMap();
			});

			mapper = mapCfg.CreateMapper();
		}

		public Product Add(Product pr)
		{
			var savePr = mapper.Map<ProductDb>(pr);

			db.Products.Add(savePr);

			db.SaveChanges();

			return mapper.Map<Product>(savePr);
		}

		public void Delete(Product pr)
		{
			db.Products.Remove(new ent.ProductDb { id = pr.id});
		}

		public IEnumerable<Product> Get(int year, int month)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Product> Get(DateTime dtFrom, DateTime dtTo)
		{
			var query = from product in db.Products
						where product.Date >= dtFrom && product.Date <= dtTo
						join productName in db.ProductNames
						on product.prodNameId equals productName.id
						join currency in db.Currencies
						on product.currencyId equals currency.id
						select new Product
						{
							id = product.id,
							prodNameId = product.prodNameId,
							name = productName.name,
							currencyName = currency.name,
							currencyId = currency.id,
							categoryId = product.categoryId,
							count = product.count,
							Date = product.Date,
							price = product.price
						};

			return query.ToArray();

			//return db.Products.Where(x => x.Date >= dtFrom && x.Date <= dtTo).Select(x => mapper.Map<Product>(x))
			//	.ToArray();
		}

		public Product Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Product> GetAll()
		{
			throw new NotImplementedException();
		}

		public decimal GetTotalSpend()
		{
			return db.Products.Sum(x => x.sum);
		}

		public Product Update(Product pr)
		{
			throw new NotImplementedException();
		}
	}
}
