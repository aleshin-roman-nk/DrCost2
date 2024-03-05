using Core.dto;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.services
{
	public class PaymentService
	{
		private readonly IPaymentRepo paymentRepo;

		public PaymentService(IPaymentRepo paymentRepo)
		{
			this.paymentRepo = paymentRepo;
		}

		public void CreateRange(IEnumerable<CreatePaymentDto> dtos)
		{
			paymentRepo.CreateRange(dtos);
		}
	}
}
