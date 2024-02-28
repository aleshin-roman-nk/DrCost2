using Core.entity;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.services
{
	public class ProductNameService
	{
		private readonly IProductNameRepo repo;

		public ProductNameService(IProductNameRepo repo)
		{
			this.repo = repo;
		}

		public IEnumerable<ProductName> GetAll()
		{
			return repo.GetAll();
		}

		public ProductName Add(ProductName ptype)
		{
			return repo.Add(ptype);
		}

		public ProductName Update(ProductName ptype)
		{
			return repo.Update(ptype);
		}

		public void Remove(ProductName ptype)
		{
			repo.Delete(ptype);
		}
	}
}
