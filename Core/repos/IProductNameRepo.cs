using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.entity;

namespace Core.repos
{
    public interface IProductNameRepo: IRepo<ProductName>
	{
		IEnumerable<ProductName> GetAll();
	}
}
