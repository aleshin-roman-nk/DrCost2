using Core.entity;
using DrCost2.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.views
{
	public interface ISelectPaymentSampleView
	{
		void ShowModal();
		event EventHandler<PaymentSample> Completed;
	}
}
