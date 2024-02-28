using Core.entity;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.services
{
	public class CurrencyService
	{
		private readonly ICurrencyRepo repo;

		public CurrencyService(ICurrencyRepo repo)
		{
			this.repo = repo;
		}

		public IEnumerable<Currency> GetAll()
		{
			return repo.GetAll();
		}
	}
}
