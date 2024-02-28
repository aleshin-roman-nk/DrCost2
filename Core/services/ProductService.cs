using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.entity;
using Core.repos;

namespace Core.services
{
    public class ProductService
	{
		private readonly IProductRepo productRepo;

		public ProductService(IProductRepo productRepo)
		{
			this.productRepo = productRepo;
		}

		public Product Add(Product prod)
		{
			return productRepo.Add(prod);
		}

		public Product Update(Product prod)
		{
			return productRepo.Update(prod);
		}

		public void Delete(Product prod)
		{
			productRepo.Delete(prod);
		}

		public IEnumerable<Product> Get(int year, int month)
		{
			return productRepo.Get(year, month);
		}

		public IEnumerable<Product> GetAll()
		{
			return productRepo.GetAll();
		}

		public decimal GetTotalSpend()
		{
			return productRepo.GetTotalSpend();
		}

		public decimal SpentIn(int year, int month)
		{

		}

		public IEnumerable<Product> Get(DateTime dtFrom, DateTime dtTo)
		{
			return productRepo.Get(dtFrom, dtTo);
		}
	}
}
