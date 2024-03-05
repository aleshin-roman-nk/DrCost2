using Core.dto;
using Core.entity;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.services
{
	public class PaymentSampleService
	{
		private readonly IPaymentSampleRepo paymentSampleRepo;

		public PaymentSampleService(IPaymentSampleRepo paymentSampleRepo)
		{
			this.paymentSampleRepo = paymentSampleRepo;
		}
		public IEnumerable<PaymentSample> GetPaymentSamples()
		{
			return paymentSampleRepo.GetAll();
		}
		public PaymentSample Create(CreatePaymentSampleDto sampleDto)
		{
			return paymentSampleRepo.Add(sampleDto);
		}
	}
}
