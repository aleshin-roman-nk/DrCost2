using Core.entity;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.services
{
	public class PaymentCategoryService
	{
		private readonly IPaymentCategoryRepo paymentCategoryRepo;

		public PaymentCategoryService(IPaymentCategoryRepo paymentCategoryRepo)
		{
			this.paymentCategoryRepo = paymentCategoryRepo;
		}

		public IEnumerable<PaymentCategory> GetAll()
		{
			return paymentCategoryRepo.GetAll();
		}

		public PaymentCategory Create(string catName)
		{
			return paymentCategoryRepo.Create(catName);
		}
	}
}
