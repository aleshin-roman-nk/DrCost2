using Core.Employment.entity;
using Core.Employment.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.services
{
	public class EmplPaymentSourceService
	{
		private readonly IEmplPaymentSourceRepo emplPaymentSourceRepo;

		public EmplPaymentSourceService(IEmplPaymentSourceRepo emplPaymentSourceRepo)
		{
			this.emplPaymentSourceRepo = emplPaymentSourceRepo;
		}

		public IEnumerable<EmplPaymentSource> GetAll()
		{
			return emplPaymentSourceRepo.GetAll();
		}
	}
}
