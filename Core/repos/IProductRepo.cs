using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.entity;

namespace Core.repos
{
    public interface IProductRepo: IRepo<Product>
	{
		IEnumerable<Product> Get(int year, int month);
		IEnumerable<Product> Get(DateTime dtFrom, DateTime dtTo);
		IEnumerable<Product> GetAll();
		decimal GetTotalSpend();
	}
}
