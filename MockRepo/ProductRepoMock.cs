using Core.entity;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepo
{
    public class ProductRepoMock : IProductRepo
	{
		public ProductRepoMock() { generateProducts(); }

		public Product Add(Product pr)
		{
			throw new NotImplementedException();
		}

		public void Delete(Product pr)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Product> Get(int year, int month)
		{
			DateTime dt1 = new DateTime(year, month, 1);
			DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));

			return _products.Where(x => x.Date >= dt1 && x.Date <= dt2).ToArray();
		}

		public Product Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Product> GetAll()
		{
			return _products;
		}

		public decimal GetTotalSpend()
		{
			return _products.Sum(x => x.sum);
		}

		public Product Update(Product pr)
		{
			throw new NotImplementedException();
		}

		private IEnumerable<Product>? _products;
		private void generateProducts()
		{
			_products = new[]
				{
					new Product { id = 1, prodNameId = 45, categoryId = 7, name = "Widget", price = 19.99m, count = 5, Date = new DateTime(2023, 06, 14) },
					new Product { id = 2, prodNameId = 12, categoryId = 3, name = "Gadget", price = 29.99m, count = 3, Date = new DateTime(2023, 01, 18) },
					new Product { id = 3, prodNameId = 23, categoryId = 5, name = "Thingamajig", price = 9.99m, count = 10, Date = new DateTime(2023, 10, 23) },
					new Product { id = 4, prodNameId = 65, categoryId = 8, name = "Doodad", price = 49.99m, count = 2, Date = new DateTime(2023, 03, 05) },
					new Product { id = 5, prodNameId = 17, categoryId = 2, name = "Doohickey", price = 5.99m, count = 15, Date = new DateTime(2023, 07, 29) },
					new Product { id = 6, prodNameId = 34, categoryId = 4, name = "Thingumabob", price = 12.49m, count = 7, Date = new DateTime(2023, 05, 11) },
					new Product { id = 7, prodNameId = 53, categoryId = 6, name = "Gizmo", price = 22.99m, count = 5, Date = new DateTime(2023, 02, 20) },
					new Product { id = 8, prodNameId = 27, categoryId = 9, name = "Whatchamacallit", price = 99.99m, count = 1, Date = new DateTime(2023, 04, 15) },
					new Product { id = 9, prodNameId = 39, categoryId = 1, name = "Thing", price = 75.00m, count = 4, Date = new DateTime(2023, 08, 09) },
					new Product { id = 10, prodNameId = 48, categoryId = 3, name = "Contrivance", price = 15.75m, count = 6, Date = new DateTime(2023, 08, 21) },
					new Product { id = 11, prodNameId = 21, categoryId = 5, name = "Gimmick", price = 55.55m, count = 5, Date = new DateTime(2023, 10, 27) },
					new Product { id = 12, prodNameId = 30, categoryId = 7, name = "Apparatus", price = 24.99m, count = 3, Date = new DateTime(2023, 09, 17) },
					new Product { id = 13, prodNameId = 44, categoryId = 2, name = "Implement", price = 32.50m, count = 2, Date = new DateTime(2023, 03, 22) },
					new Product { id = 14, prodNameId = 58, categoryId = 8, name = "Device", price = 60.00m, count = 3, Date = new DateTime(2023, 04, 14) },
					new Product { id = 15, prodNameId = 26, categoryId = 4, name = "Utensil", price = 40.40m, count = 1, Date = new DateTime(2023, 09, 25) },
					new Product { id = 16, prodNameId = 37, categoryId = 6, name = "Tool", price = 23.90m, count = 5, Date = new DateTime(2023, 01, 10) },
					new Product { id = 17, prodNameId = 49, categoryId = 9, name = "Instrument", price = 88.88m, count = 2, Date = new DateTime(2023, 02, 27) },
					new Product { id = 18, prodNameId = 51, categoryId = 1, name = "Mechanism", price = 14.95m, count = 10, Date = new DateTime(2023, 10, 04) },
					new Product { id = 19, prodNameId = 63, categoryId = 3, name = "Appliance", price = 199.95m, count = 1, Date = new DateTime(2023, 10, 20) },
					new Product { id = 20, prodNameId = 75, categoryId = 5, name = "Engine", price = 259.90m, count = 1, Date = new DateTime(2023, 04, 01) },
					new Product { id = 21, prodNameId = 75, categoryId = 5, name = "Fish", price = 150.90m, count = 1.25m, Date = new DateTime(2023, 11, 01) }
				};

		}

		public IEnumerable<Product> Get(DateTime dtFrom, DateTime dtTo)
		{
			return _products.Where(x => x.Date >= dtFrom && x.Date <= dtTo).ToArray();
		}
	}
}
