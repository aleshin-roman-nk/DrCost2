using Core.entity;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.services
{
	public class PaymentSamplePageService
	{
		private readonly IPaymentSampleRepo paymentSampleRepo;
		private readonly IFindingTagRepo findingTagRepo;

		public PaymentSamplePageService(
			IPaymentSampleRepo paymentSampleRepo,
			IFindingTagRepo findingTagRepo
			)
		{
			this.paymentSampleRepo = paymentSampleRepo;
			this.findingTagRepo = findingTagRepo;
		}

		public IEnumerable<FindingTag> GetFindingTags()
		{
			return findingTagRepo.GetAll();
		}

		public IEnumerable<PaymentSample> GetPaymentSamples()
		{
			return paymentSampleRepo.GetAll();
		}
	}
}
