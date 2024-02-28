using Core.entity;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.services
{
	public class ProductCategoryService
	{
		private readonly ICategoryRepo repo;

		public ProductCategoryService(ICategoryRepo repo)
		{
			this.repo = repo;
		}

		public IEnumerable<ProductCategory> GetAll()
		{
			return repo.GetAll();
		}
	}
}
