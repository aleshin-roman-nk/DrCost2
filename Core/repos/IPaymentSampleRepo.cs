using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.dto;
using Core.entity;

namespace Core.repos
{
    public interface IPaymentSampleRepo
	{
		IEnumerable<PaymentSample> GetAll();
		PaymentSample Add(CreatePaymentSampleDto sampleDto);
	}
}
