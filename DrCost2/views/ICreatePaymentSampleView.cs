﻿using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.views
{
	public interface ICreatePaymentSampleView
	{
		void ShowDialog();
		event EventHandler<PaymentSample> Completed;
	}
}
